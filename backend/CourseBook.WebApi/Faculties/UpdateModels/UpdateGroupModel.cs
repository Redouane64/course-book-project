namespace CourseBook.WebApi.Faculties.UpdateModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    public class UpdateGroupModel
    {
        [Required]
        public string Name { get; set; }
    }
}
