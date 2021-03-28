namespace CourseBook.WebApi.Disciplines.Repositories
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    using CourseBook.WebApi.Common.Entities;
    using CourseBook.WebApi.Disciplines.Entities;

    public interface ITeachersRepository
    {
        Task<IEnumerable<GroupDisciplineEntity>> GetTeacherDisciplines(string teacherId, CancellationToken cancellationToken);
    }
}
