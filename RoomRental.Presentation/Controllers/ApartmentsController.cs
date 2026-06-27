using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObjects;

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

    [HttpGet("{id:guid}", Name = "ApartmentById")]
    public IActionResult GetApartment(Guid id)
    {
        var apartment = _service.ApartmentService.GetApartment(id, trackChanges: false);
        return Ok(apartment);
    }

    [HttpPost]
    public IActionResult CreateApartment([FromBody] ApartmentForCreationDto apartment)
    {
        if (apartment is null)
            return BadRequest("ApartmentForCreation object is null");

        var createdAparment = _service.ApartmentService.CreateApartment(apartment);

        return CreatedAtRoute("ApartmentById", new { id = createdAparment.Id }, createdAparment);
    }

    [HttpDelete("{id:guid}")]
    public IActionResult DeleteApartment(Guid id)
    {
        _service.ApartmentService.DeleteApartment(id, trackChanges: false);
        return NoContent();
    }

    [HttpPut("{id:guid}")]
    public IActionResult UpdateApartment(Guid id, [FromBody] ApartmentForUpdateDto apartment)
    {
        if (apartment is null)
            return BadRequest("ApartmentForUpdateDto object is null");

        _service.ApartmentService.UpdateApartment(id, apartment, trackChanges: true);
        return NoContent();
    }
}
