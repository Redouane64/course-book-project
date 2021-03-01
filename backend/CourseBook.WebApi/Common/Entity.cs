namespace CourseBook.WebApi.Common
{
    using System;

    public abstract class Entity
    {
        public virtual Guid Id { get; set; }
    }
}
