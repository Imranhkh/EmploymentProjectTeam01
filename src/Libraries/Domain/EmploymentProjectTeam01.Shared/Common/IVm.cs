namespace EmploymentProjectTeam01.Shared.Common;

public interface IVm
{
    public interface IVm<T> where T : IEquatable<T>
    {
        T Id { get; set; }
    }
    public interface IVm : IVm<int>
    {
    }

}
