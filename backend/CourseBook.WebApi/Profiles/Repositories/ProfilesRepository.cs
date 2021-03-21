namespace CourseBook.WebApi.Profiles.Repositories
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    using Entities;

    using Microsoft.EntityFrameworkCore;

    using WebApi.Data;

    public class ProfilesRepository : IProfilesRepository
    {
        private readonly DataContext _context;

        public ProfilesRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<ProfileEntity> CreateAsync(ProfileEntity entity, CancellationToken cancellationToken = default)
        {
            var added = this._context.Profiles.Add(entity);
            await this._context.SaveChangesAsync(cancellationToken);

            return added.Entity;
        }

        public async Task<ProfileEntity> UpdateAsync(ProfileEntity entity, CancellationToken cancellationToken = default)
        {
            var entry = this._context.Profiles.Update(entity);
            await this._context.SaveChangesAsync(cancellationToken);
            return entry.Entity;
        }

        public Task<IEnumerable<ProfileEntity>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        public Task<ProfileEntity> GetProfileByUserId(string userId)
        {
            return this._context.Profiles.SingleOrDefaultAsync(e => e.UserId == userId);
        }
    }
}
