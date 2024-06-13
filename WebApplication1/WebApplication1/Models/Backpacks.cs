using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models;
[Table(nameof(Backpacks))]
[PrimaryKey(nameof(CharacterId), nameof(ItemId))]
public class Backpacks
{
    public int CharacterId { get; set; }
    [ForeignKey(nameof(CharacterId))]
    public Characters Characters { get; set; }

    public int ItemId { get; set; }
    [ForeignKey(nameof(ItemId))]
    public Items Items { get; set; }

    public int Amount { get; set; }
}