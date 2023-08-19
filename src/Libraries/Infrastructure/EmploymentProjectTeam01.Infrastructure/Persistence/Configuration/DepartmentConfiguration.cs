using EmploymentProjectTeam01.Model;
using EmploymentProjectTeam01.Shared.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmploymentProjectTeam01.Infrastructure.Persistence.Configuration;

public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
{
   
    public void Configure(EntityTypeBuilder <Department> builder)
    {
        builder.ToTable("Departments");
        builder.HasKey(x => x.Id);

        //builder.HasData(new
        //{
        //    Id=1,
        //    DepartmentName="IT",
        //    Created =DateTimeOffset.Now,
        //    CreatedBy="1",
        //    Status= EntityStatus.Created,


        //});
    }

   
}
