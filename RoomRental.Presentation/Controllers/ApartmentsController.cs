using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace RoomRental.Presentation.Controllers;


[Route("api/apartments")]
[ApiController]
public class ApartmentsController : ControllerBase
{
    private readonly IServiceManager _service;
    public ApartmentsController(IServiceManager service) => _service = service;

    [HttpGet]
    public IActionResult GetApartments()
    {
        var apartments = _service.ApartmentService.GetAllApartments(trackChanges: false);
        return Ok(apartments);
    }
}
