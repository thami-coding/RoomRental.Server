using Asp.Versioning;
using Entities.ErrorModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace RoomRental.Presentation.Controllers;

[Produces("application/json")]
[ApiVersion("1.0")]
[Route("api/apartments/{apartmentId}/addresses")]
[ApiController]
[ApiExplorerSettings(GroupName = "v1")]
public class AddressesController : ControllerBase
{
    private readonly IServiceManager _service;

    public AddressesController(IServiceManager service) => _service = service;


    /// <summary>
    /// Retrieves the address for a specific apartment
    /// </summary>
    /// <param name="apartmentId">The unique identifier of the apartment</param>
    /// <param name="id">The unique identifier of the address</param>
    /// <returns>The address associated with the specified apartment</returns>
    /// <response code="200">Returns the apartment address</response>
    /// <response code="404">Apartment with the provided ID was not found</response>
    [HttpGet("{id:guid}")]
    [ProducesResponseType(typeof(AddressDto), StatusCodes.Status201Created)]
    [ProducesResponseType(404)]
    public IActionResult GetAddressForApartment(Guid apartmentId, Guid id)
    {
        var address = _service.AddressService.GetAddress(apartmentId, id, trackChanges: false);
        return Ok(address);
    }


    /// <summary>
    /// Fully updates the address for a specific apartment
    /// </summary>
    /// <param name="apartmentId">The unique identifier of the apartment</param>
    /// <param name="id">The unique identifier of the address to update</param>
    /// <param name="address">The updated address data</param>
    /// <returns>No content on success</returns>
    /// <response code="204">Address successfully updated</response>
    /// <response code="400">Invalid request payload or missing required fields</response>
    /// <response code="404">Apartment or address with the provided ID was not found</response>
    [HttpPut("{id:guid}")]
    [ProducesResponseType(204)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(404)]
    public IActionResult UpdateAddressForApartment(Guid apartmentId, Guid id, [FromBody] AddressForUpdateDto address)
    {
        if (address is null)
            return BadRequest("ApartmentForUpdateDto object is null");
        if (!ModelState.IsValid)
            return UnprocessableEntity(ModelState);

        _service.AddressService.UpdateAddressForApartment(apartmentId, id, address, apartmentTrackChanges: false,
            addresssTrackChanges: true);

        return NoContent();
    }


    /// <summary>
    /// Partially updates the address for a specific apartment
    /// </summary>
    /// <param name="apartmentId">The unique identifier of the apartment</param>
    /// <param name="id">The unique identifier of the address to update</param>
    /// <param name="patchDoc">The JSON Patch document containing the partial update operations</param>
    /// <returns>No content on success</returns>
    /// <response code="204">Address successfully updated</response>
    /// <response code="400">Invalid or null patch document</response>
    /// <response code="404">Apartment or address with the provided ID was not found</response>
    [HttpPatch("{id:guid}")]
    [ProducesResponseType(204)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(404)]
    public IActionResult PartiallyUpdateAddressForApartment(Guid apartmentId, Guid id,
        [FromBody] JsonPatchDocument<AddressForUpdateDto> patchDoc)
    {
        if (patchDoc is null)
            return BadRequest("patchDoc object sent from client is null.");

        var result = _service.AddressService.GetAddressForPatch(apartmentId, id, apartmentTrackChanges: false,
            addressTrackChanges: true);

        patchDoc.ApplyTo(result.addressToPatch, ModelState);

        TryValidateModel(result.addressToPatch);

        if (!ModelState.IsValid)
            return UnprocessableEntity(ModelState);

        _service.AddressService.SaveChangesForPatch(result.addressToPatch, result.addressEntity);

        return NoContent();

    }
}
