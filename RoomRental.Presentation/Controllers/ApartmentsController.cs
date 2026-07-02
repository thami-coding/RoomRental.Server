using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace RoomRental.Presentation.Controllers;

[Produces("application/json")]
[ApiVersion("1.0", Deprecated = true)]
[Route("api/apartments")]
[ApiController]
[ApiExplorerSettings(GroupName = "v1")]
public class ApartmentsController : ControllerBase
{
    private readonly IServiceManager _service;
    public ApartmentsController(IServiceManager service) => _service = service;

    /// <summary>
    /// Retrieves all apartment listings
    /// </summary>
    /// <returns>A list of all available apartments</returns>
    /// <response code="200">Returns the list of apartments</response> 
    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<ApartmentDto>), StatusCodes.Status201Created)]
    public IActionResult GetApartments()
    {
        var apartments = _service.ApartmentService.GetAllApartments(trackChanges: false);
        return Ok(apartments);
    }

    /// <summary>
    /// Retrieves a specific apartment by ID
    /// </summary>
    /// <param name="id">The unique identifier of the apartment</param>
    /// <returns>A single apartment matching the provided ID</returns>
    /// <response code="200">Returns the requested apartment</response>
    /// <response code="404">Apartment with the provided ID was not found</response>
    [HttpGet("{id:guid}", Name = "ApartmentById")]
    [ProducesResponseType(typeof(ApartmentDto), StatusCodes.Status200OK)]
    [ProducesResponseType(404)]
    public IActionResult GetApartment(Guid id)
    {
        var apartment = _service.ApartmentService.GetApartment(id, trackChanges: false);
        return Ok(apartment);
    }

    /// <summary>
    /// Creates a new apartment listing
    /// </summary>
    /// <param name="apartment">The apartment data to create</param>
    /// <returns>The newly created apartment</returns>
    /// <response code="201">Apartment successfully created</response>
    /// <response code="400">Invalid request payload or missing required fields</response>
    [HttpPost]
    [ProducesResponseType(typeof(ApartmentDto), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult CreateApartment([FromBody] ApartmentForCreationDto apartment)
    {
        if (apartment is null)
            return BadRequest("ApartmentForCreation object is null");

        if (!ModelState.IsValid)
            return UnprocessableEntity(ModelState);

        var createdAparment = _service.ApartmentService.CreateApartment(apartment);

        return CreatedAtRoute("ApartmentById", new { id = createdAparment.Id }, createdAparment);
    }

    /// <summary>
    /// Deletes an existing apartment listing
    /// </summary>
    /// <param name="id">The unique identifier of the apartment to delete</param>
    /// <returns>No content on success</returns>
    /// <response code="204">Apartment successfully deleted</response>
    /// <response code="404">Apartment with the provided ID was not found</response>
    [HttpDelete("{id:guid}")]
    [ProducesResponseType(204)]
    [ProducesResponseType(404)]
    public IActionResult DeleteApartment(Guid id)
    {
        _service.ApartmentService.DeleteApartment(id, trackChanges: false);
        return NoContent();
    }

    /// <summary>
    /// Fully updates an existing apartment listing
    /// </summary>
    /// <param name="id">The unique identifier of the apartment to update</param>
    /// <param name="apartment">The updated apartment data</param>
    /// <returns>No content on success</returns>
    /// <response code="204">Apartment successfully updated</response>
    /// <response code="400">Invalid request payload or missing required fields</response>
    /// <response code="404">Apartment with the provided ID was not found</response>
    [HttpPut("{id:guid}")]
    [ProducesResponseType(204)]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    public IActionResult UpdateApartment(Guid id, [FromBody] ApartmentForUpdateDto apartment)
    {
        if (apartment is null)
            return BadRequest("ApartmentForUpdateDto object is null");

        if (!ModelState.IsValid)
            return UnprocessableEntity(ModelState);

        _service.ApartmentService.UpdateApartment(id, apartment, trackChanges: true);
        return NoContent();
    }
}
