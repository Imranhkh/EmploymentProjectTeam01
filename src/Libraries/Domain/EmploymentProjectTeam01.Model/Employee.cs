using EmploymentProjectTeam01.Shared.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmploymentProjectTeam01.Model;

public class Employee:BaseEntity,IEntity
{
 
    public string? Name { get; set; }=string.Empty;
    public string? Address { get; set; }= string.Empty;
    public string? Gender { get; set; } =string.Empty;
    public int DepartmentId { get; set; }   
    public Department? Department { get; set; }
    public DateTime JoiningDate { get; set; }
    public bool Ssc { get;set; }
    public bool Hsc { get; set; }
    public bool Bsc { get; set; }
    public bool Msc { get; set; }
    public string Picture { get; set; } = string.Empty;
    public int CountryId { get; set; }
    public Country? Country { get; set; }
    public int StateId { get; set; }
    public State? State { get; set; }
    public int CityId { get; set; }
    public City? City { get; set; }











}
