using System;

namespace CourseBook.WebApi.Common
{
    internal interface IRepository<T> where T : Entity, IAggregateRoot
    {
    }
}
