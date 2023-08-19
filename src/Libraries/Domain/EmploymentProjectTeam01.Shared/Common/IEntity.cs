using EmploymentProjectTeam01.Shared.Enum;

namespace EmploymentProjectTeam01.Shared.Common;

public interface IEntity<T>
     where T:IEquatable<T>
{

    DateTimeOffset Created { get; set; }
    string CreatedBy { get; set; }
    T Id { get; set; }
    DateTimeOffset? LastModified { get; set; }
    string? LastModifiedBy { get; set; }
    EntityStatus Status { get; set; }

}
public interface IEntity : IEntity<int>
{
}

