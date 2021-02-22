using System;

namespace CourseBook.WebApi.Common
{
    public abstract class Entity
    {
        public virtual Guid Id { get; set; }
    }
}
