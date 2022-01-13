using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVP.Core.Entities;

namespace MVP.Infraestructure.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(e => e.IdUser);

            builder.Property(e => e.BirthDate).HasColumnType("date")
                    .HasColumnName("BirthDate");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Name");

            builder.Property(e => e.Active)
                    .HasColumnName("Active");
        }
    }
}
