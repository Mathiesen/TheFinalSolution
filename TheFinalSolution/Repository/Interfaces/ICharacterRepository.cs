using TheFinalSolution.Entities;

namespace TheFinalSolution.Repository.Interfaces;

public interface ICharacterRepository
{
    Character? GetById(Guid id);
    void UpdateStamina(Guid id, int stamina);
}