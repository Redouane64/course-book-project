namespace CourseBook.WebApi.Admin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    public class SetRoleModel
    {
        [Required]
        public string UserId { get; set; }
        [Required]
        public string[] Roles { get; set; }
    }
}
