using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace RoomRental.Presentation.Controllers;

[Route("apartments/{apartmentId}/address")]
[ApiController]
public class AddressesController: ControllerBase
{
    private readonly IServiceManager _service;


    public AddressesController(IServiceManager service) => _service = service;
  
}
