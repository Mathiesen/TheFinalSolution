using TheFinalSolution.DataAccessLayer;
using TheFinalSolution.Entities;
using TheFinalSolution.Repository.Interfaces;

namespace TheFinalSolution.Repository;

public class CharacterRepository : ICharacterRepository
{
    private RpgContext _context;

    public CharacterRepository(RpgContext context)
    {
        _context = context;
    }
    
    public Character? GetById(Guid id)
    {
        return _context.Characters.FirstOrDefault(x => x.Id == id);
    }

    public void UpdateStamina(Guid id, int stamina)
    {
        var character = new Character { Id = id };
        _context.Characters.Attach(character);
        character.Stamina = stamina;
        _context.SaveChanges();
    }
}