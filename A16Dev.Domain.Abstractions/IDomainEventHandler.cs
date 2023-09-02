namespace A16Dev.Domain.Abstractions
{
    public interface IDomainEventHandler<T> where T : IDomainEvent
    {
        void Apply(T @event);
    }
}
