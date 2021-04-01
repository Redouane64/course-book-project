namespace CourseBook.WebApi.Faculties.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    using Common;

    using CourseBook.WebApi.Directions.Entities;
    using CourseBook.WebApi.Disciplines.Entities;
    using CourseBook.WebApi.Groups.Entities;
    using CourseBook.WebApi.Model;
    using Entities;

    public interface IFacultiesRepository : IRepository<FacultyEntity>
    {
        Task<IEnumerable<DirectionEntity>> GetDirections(Guid facultyId, CancellationToken cancellationToken);
        Task<IEnumerable<GroupEntity>> GetGroups(Guid directionId, CancellationToken cancellationToken);

        Task<IEnumerable<DisciplineEntity>> GetDisciplines(CancellationToken cancellationToken);

        Task<FacultyEntity> GetFacultyAsync(Guid id, CancellationToken cancellationToken);
        Task<DirectionEntity> GetDirectionAsync(Guid id, CancellationToken cancellationToken);
        Task<GroupEntity> GetGroupAsync(Guid id, CancellationToken cancellationToken);
        Task<DisciplineEntity> GetDisciplineAsync(Guid id, CancellationToken cancellationToken);

        Task CreateFaculty(CreateFaculty paylod, CancellationToken cancellationToken);
        Task CreateDirection(Guid facultyId, CreateDirection paylod, CancellationToken cancellationToken);

        Task CreateGroup(Guid directionId, CreateGroup paylod, CancellationToken cancellationToken);

        Task CreateDiscipline(CreateDiscipline paylod, CancellationToken cancellationToken);


        Task DeleteFaculty(Guid facultyId, CancellationToken cancellationToken);
        Task DeleteDirection(Guid directionId, CancellationToken cancellationToken);

        Task DeleteGroup(Guid groupId, CancellationToken cancellationToken);

        Task DeleteDiscipline(Guid disciplineId, CancellationToken cancellationToken);
    }
}
