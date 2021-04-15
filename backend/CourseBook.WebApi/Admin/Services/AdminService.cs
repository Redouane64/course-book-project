namespace CourseBook.WebApi.Admin.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Claims;
    using System.Threading;
    using System.Threading.Tasks;
    using CourseBook.WebApi.Data;
    using CourseBook.WebApi.Profiles.Entities;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;

    public class AdminService : IAdminService
    {
        private readonly UserManager<UserEntity> _userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly DataContext _context;
        private readonly IHttpContextAccessor httpContextAccessor;

        public AdminService(UserManager<UserEntity> userManager, DataContext context, IHttpContextAccessor httpContextAccessor, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _context = context;
            this.httpContextAccessor = httpContextAccessor;
            this.roleManager = roleManager;
        }

        public async Task DeleteUser(string Id, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByIdAsync(Id);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<UserEntity>> GetUsers(CancellationToken cancellationToken)
        {
            var currentUser = this._userManager.GetUserId(
                this.httpContextAccessor.HttpContext.User
            );

            return await _context.Users.AsNoTracking()
                .Where(x => x.Id != currentUser)
                .ToListAsync(cancellationToken);
        }
    }
}