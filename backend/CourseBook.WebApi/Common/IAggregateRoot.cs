namespace CourseBook.WebApi.Common
{
    using System;

    public interface IAggregateRoot : IEntity<Guid>
    {
    }

    public interface IAggregateRoot<TKey> : IEntity<TKey>
    {
    }
}
