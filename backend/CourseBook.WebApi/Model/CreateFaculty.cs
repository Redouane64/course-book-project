namespace CourseBook.WebApi.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    public class CreateFaculty
    {
        [Required]
        public string Name { get; set; }
    }
}
