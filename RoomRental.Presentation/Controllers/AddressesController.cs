using Asp.Versioning;
using Entities.ErrorModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using RoomRental.Presentation.ActionFilters;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace RoomRental.Presentation.Controllers;

[Consumes("application/json")]
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
    [HttpGet("{id:guid}")]
    [ProducesResponseType(typeof(AddressDto), StatusCodes.Status201Created)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> GetAddressForApartment(Guid apartmentId, Guid id)
    {
        var address = await _service.AddressService.GetAddressAsync(apartmentId, id, trackChanges: false);
        return Ok(address);
    }


    /// <summary>
    /// Fully updates the address for a specific apartment
    /// </summary>
    /// <param name="apartmentId">The unique identifier of the apartment</param>
    /// <param name="id">The unique identifier of the address to update</param>
    /// <param name="address">The updated address data</param>
    [HttpPut("{id:guid}")]
    [ProducesResponseType(204)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(404)]
    [ServiceFilter(typeof(ValidationFilterAttribute))]
    [Authorize(Roles = "Manager")]
    public async Task<IActionResult> UpdateAddressForApartment(Guid apartmentId, Guid id, [FromBody] AddressForUpdateDto address)
    {
        await _service.AddressService.UpdateAddressForApartmentAsync(apartmentId, id, address, apartmentTrackChanges: false,
            addresssTrackChanges: true);

        return NoContent();
    }


    /// <summary>
    /// Partially updates the address for a specific apartment
    /// </summary>
    /// <param name="apartmentId">The unique identifier of the apartment</param>
    /// <param name="id">The unique identifier of the address to update</param>
    /// <param name="patchDoc">The JSON Patch document containing the partial update operations</param>
    [HttpPatch("{id:guid}")]
    [Consumes("application/json-patch+json")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(404)]
    [Authorize(Roles = "Manager")]
    public async Task<IActionResult> PartiallyUpdateAddressForApartment(Guid apartmentId, Guid id,
        [FromBody] JsonPatchDocument<AddressForUpdateDto> patchDoc)
    {
        if (patchDoc is null)
            return BadRequest("patchDoc object sent from client is null.");

        var result = await _service.AddressService.GetAddressForPatchAsync(apartmentId, id, apartmentTrackChanges: false,
            addressTrackChanges: true);

        patchDoc.ApplyTo(result.addressToPatch, ModelState);

        TryValidateModel(result.addressToPatch);

        if (!ModelState.IsValid)
            return UnprocessableEntity(ModelState);

        await _service.AddressService.SaveChangesForPatchAsync(result.addressToPatch, result.addressEntity);

        return NoContent();

    }
}
