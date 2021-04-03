namespace CourseBook.WebApi.Identity.Commands
{
    using System;
    using System.Security.Claims;
    using System.Threading;
    using System.Threading.Tasks;

    using CourseBook.WebApi.Common.Events;
    using CourseBook.WebApi.Profiles.Entities;

    using MediatR;

    using Microsoft.AspNetCore.Identity;

    using Models;

    using Services;

    using ViewModels;

    public class RegisterAccountRequest : IRequest<TokenViewModel>
    {
        public RegistrationForm Form { get; }

        public RegisterAccountRequest(RegistrationForm form)
        {
            Form = form;
        }
    }

    public class RegisterAccountRequestHandler : IRequestHandler<RegisterAccountRequest, TokenViewModel>
    {
        private readonly IMediator mediator;
        private readonly UserManager<UserEntity> userManager;
        private readonly ITokensService tokensService;

        public RegisterAccountRequestHandler(
            IMediator mediator,
            UserManager<UserEntity> userManager,
            ITokensService tokensService)
        {
            this.mediator = mediator;
            this.userManager = userManager;
            this.tokensService = tokensService;
        }

        public async Task<TokenViewModel> Handle(RegisterAccountRequest request, CancellationToken cancellationToken)
        {
            /*
            * create user name from Name property, replace space with dot
            * example: John Doe => john.doe
            */
            var username = request.Form.Name.Replace(" ", ".").ToLowerInvariant();

            var user = new UserEntity {
                UserName = username,
                FullName = request.Form.Name,
                Email = request.Form.Email,
                PhoneNumber = request.Form.PhoneNumber,
                BirthDay = request.Form.Birthday,
            };

            var isStudent = request.Form.AccountType == AccountType.Student || request.Form.AccountType == AccountType.StudentTeacher;

            if (isStudent && request.Form.Education is null)
            {
                throw new InvalidOperationException("Invalid registration data.");
            }

            if (isStudent && request.Form.Education is not null)
            {
                user.AdmissionYear = request.Form.Education.AdmissionYear.Value;
                user.GroupId = request.Form.Education.Group;

            }

            var result = await this.userManager.CreateAsync(user, request.Form.Password);

            if (!result.Succeeded)
            {
                throw new Exception("Unable to create user.");
            }

            var roleResult = await this.userManager.AddToRoleAsync(user, request.Form.AccountType.ToString());

            if (!roleResult.Succeeded)
            {
                await this.userManager.DeleteAsync(user);

                throw new Exception("Unable to create user.");
            }

            if(isStudent && request.Form.Education is not null)
            {
                await this.mediator.Publish(new StudentAccountCreated(user.Id, request.Form.Education.Group), cancellationToken);
            }

            var claims = new Claim[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Role, request.Form.AccountType.ToString()),
            };

            var (Token, RefreshToken) = await this.tokensService.GenerateToken(claims, user);

            return new TokenViewModel(Token, RefreshToken, user.Id) {
                Role = request.Form.AccountType,
                Group = user.GroupId
            };
        }
    }
}
