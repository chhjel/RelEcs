namespace RelEcs.Abstractions;

public interface IComponentRemovedAutoTrigger
{
    public Entity? Entity { get; set; }
    public object? Component { get; set; }
}
