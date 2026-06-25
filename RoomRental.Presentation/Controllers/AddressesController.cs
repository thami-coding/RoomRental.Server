using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace RoomRental.Presentation.Controllers;

[Route("api/apartments/{apartmentId}/addresses")]
[ApiController]
public class AddressesController : ControllerBase
{
    private readonly IServiceManager _service;

    public AddressesController(IServiceManager service) => _service = service;

    [HttpGet("{id:guid}")]
    public IActionResult GetAddressForApartment(Guid apartmentId, Guid id)
    {
        var address = _service.AddressService.GetAddress(apartmentId, id, trackChanges: false);
        return Ok(address);
    }

}
