using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplication1.Models;
[Table(nameof(Titles))]
public class Titles
{   
    [Key]
    public int Id { get; set; }
    [MaxLength(100)]
    public string Name { get; set; }
    public IEnumerable<Character_Titles> CharacterTitles { get; set; }
    
}