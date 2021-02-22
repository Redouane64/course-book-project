using System;

namespace CourseBook.WebApi.Common
{
    internal abstract class Entity
    {
        public virtual Guid Id { get; set; }
    }
}
