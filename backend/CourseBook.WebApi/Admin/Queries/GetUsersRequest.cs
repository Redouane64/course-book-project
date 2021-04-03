namespace CourseBook.WebApi.Admin.Queries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using AutoMapper;
    using CourseBook.WebApi.Admin.Services;
    using CourseBook.WebApi.Admin.ViewModels;
    using CourseBook.WebApi.Data;
    using MediatR;

    public class GetUsersRequest : IRequest<IEnumerable<UsersViewModel>>
    { }


    public class GetUsersRequestHanlder : IRequestHandler<GetUsersRequest, IEnumerable<UsersViewModel>>
    {
        private readonly IAdminService adminService;
        public readonly IMapper mapper;

        public GetUsersRequestHanlder(IAdminService adminService, IMapper mapper)
        {
            this.adminService = adminService;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<UsersViewModel>> Handle(GetUsersRequest request, CancellationToken cancellationToken)
        {
            var users = await adminService.GetUsers(cancellationToken);
            return this.mapper.Map<IEnumerable<UsersViewModel>>(users);
        }
    }

}
