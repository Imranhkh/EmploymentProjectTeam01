using EmploymentProjectTeam01.Shared.Common;

namespace EmploymentProjectTeam01.Model;

public class Department:BaseEntity,IEntity
{

    
    public string DepartmentName { get;set; }=string.Empty;

    public ICollection<Employee> Employees { get; set; }=new HashSet<Employee>();
}
