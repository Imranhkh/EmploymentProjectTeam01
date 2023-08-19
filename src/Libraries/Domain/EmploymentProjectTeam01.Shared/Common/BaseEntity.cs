using EmploymentProjectTeam01.Shared.Enum;

namespace EmploymentProjectTeam01.Shared.Common;

public class BaseEntity:IEntity
{
  
    public DateTimeOffset Created { get; set; } = DateTimeOffset.UtcNow; 
    public string CreatedBy { get; set; } = string.Empty;


    public DateTimeOffset? LastModified { get; set; }


    public string? LastModifiedBy { get; set; }

    
    public EntityStatus Status { get; set; }
    public int Id { get ; set ; }
}
