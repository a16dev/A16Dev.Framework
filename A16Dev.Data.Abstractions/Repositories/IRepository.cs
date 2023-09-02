namespace A16Dev.Data.Abstractions
{
    public interface IRepository
    {
        IUnitOfWork UnitOfWork { get; }
    }
}