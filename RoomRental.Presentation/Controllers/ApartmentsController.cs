using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoomRental.Presentation.ActionFilters;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace RoomRental.Presentation.Controllers;

[Consumes("application/json")]
[Produces("application/json")]
[ApiVersion("1.0")]
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
    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<ApartmentDto>), StatusCodes.Status201Created)]
    public async Task<IActionResult> GetApartments()
    {
        var apartments = await _service.ApartmentService.GetAllApartmentsAsync(trackChanges: false);
        return Ok(apartments);
    }

    /// <summary>
    /// Retrieves a specific apartment by ID
    /// </summary>
    /// <param name="id">The unique identifier of the apartment</param>
    [HttpGet("{id:guid}", Name = "ApartmentById")]
    [ProducesResponseType(typeof(ApartmentDto), StatusCodes.Status200OK)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> GetApartment(Guid id)
    {
        var apartment = await _service.ApartmentService.GetApartmentAsync(id, trackChanges: false);
        return Ok(apartment);
    }

    /// <summary>
    /// Creates a new apartment listing
    /// </summary>
    /// <param name="apartment">The apartment data to create</param>
    [HttpPost]
    [ProducesResponseType(typeof(ApartmentDto), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ServiceFilter(typeof(ValidationFilterAttribute))]
    [Authorize(Roles ="Manager")]
    public async Task<IActionResult> CreateApartment([FromBody] ApartmentForCreationDto apartment)
    {
        var createdAparment = await _service.ApartmentService.CreateApartmentAsync(apartment);

        return CreatedAtRoute("ApartmentById", new { id = createdAparment.Id }, createdAparment);
    }

    /// <summary>
    /// Deletes an existing apartment listing
    /// </summary>
    /// <param name="id">The unique identifier of the apartment to delete</param>
    [HttpDelete("{id:guid}")]
    [ProducesResponseType(204)]
    [ProducesResponseType(404)]
    [Authorize(Roles = "Manager")]
    public async Task<IActionResult> DeleteApartment(Guid id)
    {
        await _service.ApartmentService.DeleteApartmentAsync(id, trackChanges: false);

        return NoContent();
    }

    /// <summary>
    /// Fully updates an existing apartment listing
    /// </summary>
    /// <param name="id">The unique identifier of the apartment to update</param>
    /// <param name="apartment">The updated apartment data</param>
    [HttpPut("{id:guid}")]
    [ProducesResponseType(204)]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    [ServiceFilter(typeof(ValidationFilterAttribute))]
    [Authorize(Roles = "Manager")]
    public async Task<IActionResult> UpdateApartment(Guid id, [FromBody] ApartmentForUpdateDto apartment)
    {
        await _service.ApartmentService.UpdateApartmentAsync(id, apartment, trackChanges: true);

        return NoContent();
    }
}
