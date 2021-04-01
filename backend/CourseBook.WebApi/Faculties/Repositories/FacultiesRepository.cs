namespace CourseBook.WebApi.Faculties.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using CourseBook.WebApi.Common.Entities;
    using CourseBook.WebApi.Data;
    using CourseBook.WebApi.Directions.Entities;
    using CourseBook.WebApi.Disciplines.Entities;
    using CourseBook.WebApi.Faculties.Entities;
    using CourseBook.WebApi.Groups.Entities;
    using CourseBook.WebApi.Model;
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

        public async Task<IEnumerable<DisciplineEntity>> GetDisciplines(CancellationToken cancellationToken = default)
        {
            return await _context.Disciplines.AsNoTracking().ToListAsync(cancellationToken);
        }

        public async Task<FacultyEntity> GetFacultyAsync(Guid id, CancellationToken cancellationToken)
        {
            return await _context.Faculties.AsNoTracking()
                .Include(x => x.Directions)
                .SingleOrDefaultAsync(x => x.Id == id, cancellationToken);
        }

        public async Task<DirectionEntity> GetDirectionAsync(Guid id, CancellationToken cancellationToken)
        {
            return await _context.Directions.AsNoTracking()
                .Include(x => x.Disciplines)
                .Include(x => x.Groups)
                .Include(x => x.Faculty)
                .SingleOrDefaultAsync(x => x.Id == id, cancellationToken);
        }

        public async Task<GroupEntity> GetGroupAsync(Guid id, CancellationToken cancellationToken)
        {
            return await _context.Groups.AsNoTracking()
                .Include(x => x.Direction)
                .Include(x => x.Disciplines)
                .SingleOrDefaultAsync(x => x.Id == id, cancellationToken);
        }

        public async Task<DisciplineEntity> GetDisciplineAsync(Guid id, CancellationToken cancellationToken)
        {
            return await _context.Disciplines.AsNoTracking()
                .Include(x => x.Directions)
                .Include(x => x.Groups)
                .SingleOrDefaultAsync(x => x.Id == id, cancellationToken);
        }

        public async Task CreateFaculty(CreateFaculty payload, CancellationToken cancellationToken)
        {
            var faculty = new FacultyEntity
            {
                Name = payload.Name

            };

            this._context.Faculties.Add(faculty);

            await this._context.SaveChangesAsync(cancellationToken);
        }

        public async Task CreateDirection(CreateDirection payload, CancellationToken cancellationToken)
        {
            var direction = new DirectionEntity
            {
                FacultyId = payload.FacultyId,
                Name = payload.Name
            };

            this._context.Directions.Add(direction);

            await this._context.SaveChangesAsync(cancellationToken);
        }

        public async Task CreateGroup(CreateGroup payload, CancellationToken cancellationToken)
        {
            var group = new GroupEntity
            {
                DirectionId = payload.DirectionId,
                Name = payload.Name
            };

            this._context.Groups.Add(group);

            await this._context.SaveChangesAsync(cancellationToken);
        }

        public async Task CreateDiscipline(CreateDiscipline payload, CancellationToken cancellationToken)
        {
            var discipline = new DisciplineEntity
            {
                 Name = payload.Name
            };

            this._context.Disciplines.Add(discipline);

            await this._context.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteFaculty(Guid facultyId, CancellationToken cancellationToken)
        {
            var faculty = await this._context.Faculties
                .FirstOrDefaultAsync(x => x.Id == facultyId);

            if (faculty is null) {
                return;
            }

            this._context.Faculties.Remove(faculty);

            await this._context.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteDirection(Guid directionId, CancellationToken cancellationToken)
        {
            var direction = await this._context.Directions
                .FirstOrDefaultAsync(x => x.Id == directionId);

            if (direction is null) {
                return;
            }

            this._context.Directions.Remove(direction);

            await this._context.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteGroup(Guid groupId, CancellationToken cancellationToken)
        {
            var group = await this._context.Groups
                .FirstOrDefaultAsync(x => x.Id == groupId);

            if (group is null) {
                return;
            }

            this._context.Groups.Remove(group);

            await this._context.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteDiscipline(Guid disciplineId, CancellationToken cancellationToken)
        {
            var discipline = await this._context.Disciplines
                .FirstOrDefaultAsync(x => x.Id == disciplineId);

            if (discipline is null) {
                return;
            }

            this._context.Disciplines.Remove(discipline);

            await this._context.SaveChangesAsync(cancellationToken);
        }
    }
}
