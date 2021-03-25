
namespace CourseBook.WebApi.Profiles.Entities
{
    using System;
    using CourseBook.WebApi.Common;
    using Microsoft.AspNetCore.Identity;

    public abstract class IdentityEntity : IdentityUser, IAggregateRoot<string>
    {
    }
}
