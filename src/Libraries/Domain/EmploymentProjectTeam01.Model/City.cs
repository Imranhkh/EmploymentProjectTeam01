using EmploymentProjectTeam01.Shared.Common;

namespace EmploymentProjectTeam01.Model;

public class City:BaseEntity,IEntity
{
    public string CityName { get;set; }=string.Empty;
    public int StateId { get;set; }
    public State State { get; set; }
    public ICollection<Employee> Employees { get; set; }=new HashSet<Employee>();
}
