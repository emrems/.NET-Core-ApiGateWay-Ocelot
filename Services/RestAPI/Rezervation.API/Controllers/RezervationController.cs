using Microsoft.AspNetCore.Mvc;
using Rezervation.API.Infrastructure;
using RezervationAPI.Models;

[ApiController]
[Route("api/res")]
public class RezervationController : ControllerBase
{
    private readonly IRezervationService _service;

    public RezervationController(IRezervationService service)
    {
        _service = service;
    }

    [HttpGet("{id}")]
    public RezervationDto GetById(int id)
    {
        return _service.getRezervationByBkgNumber(id);
    }
}
