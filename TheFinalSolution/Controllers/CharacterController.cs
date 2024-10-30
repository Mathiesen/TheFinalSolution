using Microsoft.AspNetCore.Mvc;
using TheFinalSolution.Entities;
using TheFinalSolution.Repository.Interfaces;

namespace TheFinalSolution.Controllers;

[Controller]
[Route("[controller]")]
public class CharacterController : ControllerBase
{
    private readonly ICharacterRepository _repository;
    
    public CharacterController(ICharacterRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public IActionResult Get(Guid id)
    {
        var character = _repository.GetById(id);
        if (character == null)
        {
            return NotFound();
        }
        
        return Ok(character);
    }

    [HttpPut]
    public IActionResult Put(Guid id, [FromBody] int stamina)
    {
        _repository.UpdateStamina(id, stamina);
        return Ok();
    }
}