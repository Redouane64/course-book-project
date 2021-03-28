namespace CourseBook.WebApi.Disciplines.Repositories
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    using CourseBook.WebApi.Common.Entities;
    using CourseBook.WebApi.Data;
    using CourseBook.WebApi.Disciplines.Entities;

    using Microsoft.EntityFrameworkCore;

    public class TeachersRepository : ITeachersRepository
    {
        private readonly DataContext _context;

        public TeachersRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<GroupDisciplineEntity>> GetTeacherDisciplines(string teacherId, CancellationToken cancellationToken)
        {
            return await _context.Set<GroupDisciplineEntity>()
                .AsNoTracking()
                .Include(x => x.Group)
                .Include(x => x.Discipline)
                .Where(x => x.TeacherId == teacherId)
                .OrderBy(x => x.Year)
                .ThenBy(x => x.Discipline.Name)
                .ToListAsync(cancellationToken);
        }
    }
}
