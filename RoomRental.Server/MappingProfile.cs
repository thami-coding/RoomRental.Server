using AutoMapper;
using Entities.Models;
using Shared.DataTransferObjects;

namespace RoomRental.Server;

public class MappingProfile : Profile
{
    public MappingProfile()
    {

        CreateMap<Apartment, ApartmentDto>();
        CreateMap<Address, AddressDto>();
    }
}
