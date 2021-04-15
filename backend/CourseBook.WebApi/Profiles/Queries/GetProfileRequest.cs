namespace CourseBook.WebApi.Profiles.Queries
{
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    using AutoMapper;
    using CourseBook.WebApi.Data;
    using CourseBook.WebApi.Profiles.Entities;
    using CourseBook.WebApi.Profiles.ViewModels;

    using MediatR;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Services;

    public class GetProfileRequest : IRequest<ProfileViewModel>
    {
        public string Id { get; }

        public GetProfileRequest(string id)
        {
            Id = id;
        }
    }

    public class GetProfileRequestHandler : IRequestHandler<GetProfileRequest, ProfileViewModel>
    {
        private readonly IProfileService _profileService;
        private readonly IMapper mapper;
        private readonly DataContext contact;
        private readonly UserManager<UserEntity> userManager;

        public GetProfileRequestHandler(IProfileService profileService, IMapper mapper, DataContext contact, UserManager<UserEntity> userManager)
        {
            this._profileService = profileService;
            this.mapper = mapper;
            this.contact = contact;
            this.userManager = userManager;
        }

        public async Task<ProfileViewModel> Handle(GetProfileRequest request, CancellationToken cancellationToken)
        {
            var user = await this._profileService.GetProfile(request.Id, cancellationToken);
            var vm = this.mapper.Map<ProfileViewModel>(user);

            if (await userManager.IsInRoleAsync(user, "Student")) {
                var group = await this.contact.Groups.AsNoTracking()
                    .Include(e => e.Direction)
                    .ThenInclude(e => e.Faculty)
                    .FirstOrDefaultAsync(e => e.Id == user.GroupId);

                vm.Group = group.Name;
                vm.Direction = group.Direction.Name;
                vm.Faculty = group.Direction.Faculty.Name;
            }

            var roles = await this.userManager.GetRolesAsync(user);
            vm.Roles = roles.ToArray();

            return vm;
        }
    }
}
