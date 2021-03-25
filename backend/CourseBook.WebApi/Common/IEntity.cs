namespace CourseBook.WebApi.Common
{
    using System;

    public interface IEntity<TKey>
    {
        TKey Id { get; set; }
    }
}
