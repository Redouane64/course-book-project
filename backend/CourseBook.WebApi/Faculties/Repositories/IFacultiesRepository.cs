namespace CourseBook.WebApi.Faculties.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    using Common;
    using Entities;

    public interface IFacultiesRepository : IRepository<FacultyEntity>
    {
        Task<IEnumerable<DirectionEntity>> GetDirections(Guid facultyId, CancellationToken cancellationToken);
        Task<IEnumerable<GroupEntity>> GetGroups(Guid directionId, CancellationToken cancellationToken);

        Task<IEnumerable<DisciplineEntity>> GetDisciplines(CancellationToken cancellationToken);

        Task<FacultyEntity> GetFaculty(Guid id);
        Task<DirectionEntity> GetDirection(Guid id);
        Task<DisciplineEntity> GetDiscipline(Guid id);
    }
}
