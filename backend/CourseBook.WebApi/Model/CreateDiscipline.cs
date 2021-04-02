namespace CourseBook.WebApi.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    public class CreateDiscipline
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int Semester { get; set; }
        [Required]
        public int Year { get; set; }

        public string Description { get; set; }

        public string Readings { get; set; }
        [Required]
        public List<DisciplineTeacherGroup> Groups { get; set; }

    }

    public class DisciplineTeacherGroup
    {
        [Required]
        public string Teacher { get; set; }
        [Required]
        public Guid Group { get; set; }
    }

}
