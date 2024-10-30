using Microsoft.AspNetCore.Mvc;
using TheFinalSolution.Repository.Interfaces;

namespace TheFinalSolution.Controllers;

[Controller]
[Route("[controller]")]
public class CommandController : ControllerBase
{
    private readonly ICommandRepository _commandRepository;
    
    public CommandController(ICommandRepository commandRepository)
    {
        _commandRepository = commandRepository;
    }

   
}
