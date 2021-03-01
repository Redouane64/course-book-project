namespace CourseBook.WebApi.Common
{
    using System;

    internal abstract class Entity
    {
        public virtual Guid Id { get; set; }
    }
}
