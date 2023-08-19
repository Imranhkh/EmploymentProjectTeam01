using EmploymentProjectTeam01.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Security.Cryptography.X509Certificates;

namespace EmploymentProjectTeam01.Infrastructure.Persistence.Configuration;

public class CountryConfiguration : IEntityTypeConfiguration<Country>
{
    

    public void Configure(EntityTypeBuilder<Country> builder)
    {
        builder.ToTable("Countries");
        builder.HasKey(x => x.Id);



        //builder.HasData(new
        //{


        //});

    }
}
