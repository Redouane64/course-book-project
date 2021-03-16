namespace CourseBook.WebApi.Faculties.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using CourseBook.WebApi.Data;
    using CourseBook.WebApi.Faculties.Entities;
    using Microsoft.EntityFrameworkCore;

    public class FacultiesRepository : IFacultiesRepository
    {

        private readonly DataContext _context;

        public FacultiesRepository(DataContext context)
        {
            _context = context;
        }

        public Task<FacultyEntity> CreateAsync(FacultyEntity entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<FacultyEntity>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await _context.Faculties.AsNoTracking().ToListAsync(cancellationToken);
        }

        public Task<IEnumerable<FacultyEntity>> GetFaculties(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<FacultyEntity> UpdateAsync(FacultyEntity entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<DirectionEntity>> GetDirections(Guid facultyId, CancellationToken cancellationToken = default)
        {
            return await _context.Directions.AsNoTracking().Where(x => x.FacultyId == facultyId).ToListAsync(cancellationToken);
        }

        public async Task<IEnumerable<GroupEntity>> GetGroups(Guid directionId, CancellationToken cancellationToken = default)
        {
            return await _context.Groups.AsNoTracking().Where(x => x.DirectionId == directionId).ToListAsync(cancellationToken);
        }
    }
}
