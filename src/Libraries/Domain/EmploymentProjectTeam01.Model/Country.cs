using EmploymentProjectTeam01.Shared.Common;

namespace EmploymentProjectTeam01.Model;

public class Country:BaseEntity,IEntity
{
    public string CountryName { get; set; }=string.Empty;
    public ICollection<State> States { get; set; }=new HashSet<State>();

    public ICollection<Employee> Employees { get; set; } =new HashSet<Employee>();
}
