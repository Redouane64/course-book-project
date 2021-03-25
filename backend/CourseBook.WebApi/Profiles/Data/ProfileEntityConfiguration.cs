namespace CourseBook.WebApi.Profiles.Data
{
    using CourseBook.WebApi.Models;
    using Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ProfileEntityConfiguration : IEntityTypeConfiguration<ProfileEntity>
    {
        public void Configure(EntityTypeBuilder<ProfileEntity> builder)
        {
            builder.ToTable("profiles");

            builder.Property(e => e.UserId)
                .IsRequired();

            builder.Property(e => e.FullName)
                .IsRequired();

            builder.Property(e => e.AdmissionYear)
                .IsRequired();

            builder.Property(e => e.BirthDay)
                .IsRequired();

            builder.Property(e => e.Faculty)
                .IsRequired();

            builder.Property(e => e.Direction)
                .IsRequired();

            builder.Property(e => e.Group)
                .IsRequired();

            builder.Ignore(e => e.User);

            builder.Ignore(e => e.AccountType);
        }
    }
}
