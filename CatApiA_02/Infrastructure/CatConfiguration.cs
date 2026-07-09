using CatApiA_02.Domain;
using Microsoft.EntityFrameworkCore;

namespace CatApiA_02.Infrastructure
{
    public class CatConfiguration: IEntityTypeConfiguration<Cat>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Cat> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).HasColumnName("name").IsRequired().HasMaxLength(100);
            builder.Property(c => c.Description).HasColumnName("description").IsRequired().HasMaxLength(500);
            builder.Property(c => c.DateBirth).HasColumnName("date_birth").IsRequired();
            builder.Property(c => c.Weight).HasColumnName("weight").IsRequired();
            builder.Property(c => c.Height).HasColumnName("height").IsRequired();
            builder.Property(c => c.Breed).HasColumnName("breed").IsRequired().HasMaxLength(100);
        }
    }
}
