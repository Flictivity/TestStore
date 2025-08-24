using System.ComponentModel.DataAnnotations.Schema;

namespace TestStore.Data.Entities;
/// <summary>
/// Сущность Ресурс поступления
/// </summary>
public sealed class ReceiptResource
{
    public int Id { get; set; }
    public int ReceiptDocumentId { get; set; }
    [ForeignKey(nameof(ReceiptDocumentId))]
    public ReceiptDocument ReceiptDocument { get; set; } = null!;
    
    public int ResourceId { get; set; }
    [ForeignKey(nameof(ResourceId))]
    public Resource Resource { get; set; } = null!;
    
    public int UnitId { get; set; }
    [ForeignKey(nameof(UnitId))] 
    public Unit Unit { get; set; } = null!;
    
    public int Count { get; set; }
}