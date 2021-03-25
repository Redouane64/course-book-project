
namespace CourseBook.WebApi.Profiles.Entities
{
    using System;
    using CourseBook.WebApi.Common;
    using Microsoft.AspNetCore.Identity;

    public abstract class IdentityEntity : IdentityUser<Guid>, IAggregateRoot
    {
        Guid IEntity.Id { get { return this.Id; } set { /* TODO: */ } }
    }
}
