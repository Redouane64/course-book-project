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

        Task<IEnumerable<GroupDisciplineEntity>> GetTeacherDisciplines(string teacherId, CancellationToken cancellationToken);
        Task<IEnumerable<GroupDisciplineEntity>> GetStudentDisciplines(string studentId, CancellationToken cancellationToken);
    }
}
