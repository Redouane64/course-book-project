namespace CourseBook.WebApi.Profiles.Data
{
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

            builder.Property(e => e.Name)
                .IsRequired();

            builder.Property(e => e.AdmissionYear)
                .IsRequired();

            builder.Property(e => e.BirthDay)
                .IsRequired();

            builder.Ignore(e => e.User);
        }
    }
}
