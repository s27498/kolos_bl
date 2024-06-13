using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public class Characters
{
    [Key]
    public int Id { get; set; }
    [MaxLength(50)]
    public string FirstName { get; set; }
    [MaxLength(120)]
    public string LastName { get; set; }
    public int CurrentWei { get; set; }
    public int MaxWeight { get; set; }
    public IEnumerable<Backpacks> Backpacks { get; set; }
    public IEnumerable<Character_Titles> CharacterTitles { get; set; }
    
    
    
}