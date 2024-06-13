using System.Runtime.InteropServices.JavaScript;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Context;
using WebApplication1.Models;
using WebApplication1.Models.DTOs;

namespace WebApplication1.Services;

public class InventoryService
{
    private readonly ApplicationContext _context;

    public InventoryService(ApplicationContext context)
    {
        _context = context;
    }

    public async Task <List<ReturnDTO>> InsertIntoInventory(IEnumerable<int> id, int characterId)
    {
        List<ReturnDTO> result = new List<ReturnDTO>();
        using (var transaction = await _context.Database.BeginTransactionAsync())
        {
            try
            {
                var CombinedWeight = 0;
                foreach (var ItemId in id)
                {
                    
                    var Item = await _context.ItemsEnumerable.FindAsync(ItemId);
                    // combined weight to increase characters current weight later
                    CombinedWeight += Item.Weight;
                    
                    var Backpack = new Backpacks()
                    {
                        CharacterId = characterId,
                        ItemId = ItemId,
                        Amount = 1
                    };
                    var objectTmp = new ReturnDTO()
                    {
                        CharacterId = Backpack.CharacterId,
                        ItemId = Backpack.ItemId,
                        Amount = Backpack.Amount
                    };
                    result.Add(objectTmp);
                    
                    
                    await _context.BackpacksEnumerable.AddAsync(Backpack);
                    
                    await _context.SaveChangesAsync();
                }

                var character = await _context.CharactersEnumerable.FindAsync(characterId);
                character.CurrentWei += CombinedWeight;
                await _context.SaveChangesAsync();
                
                await transaction.CommitAsync();
                return result;

            }
            catch (Exception)
            {
                await transaction.RollbackAsync();
                throw;
            }
        }
    }

    public async Task<bool> DoesItemExist(IEnumerable<int> Ids)
    {
        foreach (var Id in Ids)
        {
            var possibleItem = await _context.ItemsEnumerable.FindAsync(Id);
            if (possibleItem == null)
            {
                return false;
            }
        }

        return true;
    }

    public async Task<bool> CanCharacterPickUp(IEnumerable<int> Ids, int Id)
    {
        var CombinedWeight = 0;
        foreach (var ItemId in Ids)
        {
            var Item = await _context.ItemsEnumerable.FindAsync(ItemId);
            CombinedWeight += Item.Weight;
        }

        var Character = await _context.CharactersEnumerable.FindAsync(Id);
        var CurrentWeight = Character.CurrentWei;
        var MaxWeight = Character.MaxWeight;
        var WeightCharacterCanCarry = MaxWeight - CurrentWeight;
        if (CombinedWeight > WeightCharacterCanCarry)
        {
            return false;
        }
        return true;
    }
    public async Task<bool> DoesCharacterExist(int id)
    {
        var possibleCharacter = await _context.CharactersEnumerable.FindAsync(id);
        return possibleCharacter != null;
    }
    public async Task<bool> IsItemInInventory(int characterId, IEnumerable<int> itemIds)
    {
        return await _context.BackpacksEnumerable
            .AnyAsync(bp => bp.CharacterId == characterId && itemIds.Contains(bp.ItemId));
    }

}