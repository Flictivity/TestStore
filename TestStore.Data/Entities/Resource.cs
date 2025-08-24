namespace TestStore.Data.Entities;
/// <summary>
/// Сущность Ресурс
/// </summary>
/// 
public sealed class Resource
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public bool IsArchive { get; set; }
}