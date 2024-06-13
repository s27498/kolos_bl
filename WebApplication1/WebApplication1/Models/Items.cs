using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models;
[Table(nameof(Items))]
public class Items
{
    [Key] public int Id { get; set; }
    [MaxLength(100)]
    public string Name { get; set; }
    public int Weight { get; set; }
    public IEnumerable<Backpacks> Backpacks { get; set; }

}