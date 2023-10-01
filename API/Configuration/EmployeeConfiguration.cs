using API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Configuration;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {

        builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
        builder.Property(p => p.Surname).IsRequired().HasMaxLength(100);
        builder.Property(p => p.DOB).IsRequired();
        builder.Property(p => p.PhoneNumber).IsRequired();
        builder.Property(p => p.SeriaNumber).IsRequired();
        builder.Property(p => p.Salary).IsRequired();
        builder.Property(p => p.CurrentAddress).IsRequired();

        builder.HasIndex(p => p.SeriaNumber).IsUnique();
    }
}
