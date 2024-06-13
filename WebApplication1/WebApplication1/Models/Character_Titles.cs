using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models;
[Table(nameof(Character_Titles))]
[PrimaryKey(nameof(CharacterId), nameof(TitleId))]
public class Character_Titles
{
    public int CharacterId { get; set; }
    [ForeignKey(nameof(CharacterId))] 
    public Characters Character { get; set; }
    public int TitleId { get; set; }
    [ForeignKey(nameof(TitleId))] 
    public Titles Title { get; set; }
    
    public DateTime AcquiredAt { get; set; }
}