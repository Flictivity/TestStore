namespace TestStore.Data.Entities;
/// <summary>
/// Сущность Документ поступления
/// </summary>
public sealed class ReceiptDocument
{
    public int Id { get; set; }
    public string DocumentNumber { get; set; } = null!;
    public DateOnly DocumentDate { get; set; }
}