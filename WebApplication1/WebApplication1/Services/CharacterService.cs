using Microsoft.EntityFrameworkCore;
using WebApplication1.Context;
using WebApplication1.Models.DTOs;

namespace WebApplication1.Services;

public class CharacterService
{
    private readonly ApplicationContext _context;

    public CharacterService(ApplicationContext context)
    {
        _context = context;
    }

    public async Task<GetDTO> GetCharacter(int id)
    {
        var character = await _context.CharactersEnumerable
            .Where(chr => chr.Id == id)
            .Select(chr => new GetDTO()
            {
                FirstName = chr.FirstName,
                LastName = chr.LastName,
                CurrentWeight = chr.CurrentWei,
                MaxWeight = chr.MaxWeight,

                BackpackItems = chr.Backpacks
                    .Select(bck => new ItemsDTO()
                    {
                        Amount = bck.Amount,
                        ItemName = bck.Items.Name,
                        ItemWeight = bck.Items.Weight
                    }).ToList(),
                Titles = chr.CharacterTitles
                    .Select(tit => new TitleDTO()
                    {
                        AquiredAt = tit.AcquiredAt,
                        Title = tit.Title.Name
                    }).ToList()

            }).FirstOrDefaultAsync();
        return character;
    }

    public async Task<bool> DoesCharacterExist(int id)
    {
        var possibleCharacter = await _context.CharactersEnumerable.FindAsync(id);
        return possibleCharacter != null;
    }
}