using EmploymentProjectTeam01.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmploymentProjectTeam01.Infrastructure.Persistence.Configuration;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
   

    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.ToTable("Employees");
        builder.HasKey(x => x.Id);
        builder.HasOne(x=>x.Department).WithMany(x => x.Employees).HasForeignKey(x => x.DepartmentId).IsRequired(true);
        builder.HasOne(x=>x.Country).WithMany(x => x.Employees).HasForeignKey(x => x.CountryId).IsRequired(true);
        builder.HasOne(x=>x.State).WithMany(x => x.Employees).HasForeignKey(x => x.StateId).IsRequired(true);
        builder.HasOne(x=>x.City).WithMany(x => x.Employees).HasForeignKey(x => x.CityId).IsRequired(true);




        //builder.HasData(new
        //{



        //});
    }
}
