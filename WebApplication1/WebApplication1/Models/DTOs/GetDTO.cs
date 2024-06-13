namespace WebApplication1.Models.DTOs;

public class GetDTO
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int CurrentWeight { get; set; }
    public int MaxWeight { get; set; }
    public IEnumerable<ItemsDTO> BackpackItems { get; set; }
    public IEnumerable<TitleDTO> Titles { get; set; }
}

public class ItemsDTO
{
    public string ItemName { get; set; }
    public int ItemWeight { get; set; }
    public int Amount { get; set; }
}

public class TitleDTO
{
    public string Title { get; set; }
    public DateTime AquiredAt { get; set; }
}