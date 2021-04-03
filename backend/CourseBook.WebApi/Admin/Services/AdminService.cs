namespace CourseBook.WebApi.Admin.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using CourseBook.WebApi.Data;
    using CourseBook.WebApi.Profiles.Entities;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;

    public class AdminService : IAdminService
    {
        private readonly UserManager<UserEntity> _userManager;
        private readonly DataContext _context;

        public AdminService(UserManager<UserEntity> userManager, DataContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        public async Task DeleteUser(string Id, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByIdAsync(Id);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<UserEntity>> GetUsers(CancellationToken cancellationToken)
        {
            return await _context.Users.AsNoTracking().ToListAsync(cancellationToken);
        }
    }
}
