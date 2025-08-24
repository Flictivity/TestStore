namespace TestStore.Data.Entities;

/// <summary>
/// Сущность Единица измерения
/// </summary>

public sealed class Unit
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public bool IsArchive { get; set; }
}