using AutoMapper;
using Entities.Models;
using Shared.DataTransferObjects;

namespace RoomRental.Server;

public class MappingProfile : Profile
{
    public MappingProfile()
    {

        CreateMap<Apartment, ApartmentsDto>();
        CreateMap<Apartment, ApartmentDto>();
        CreateMap<Address, AddressDto>();
        CreateMap<Image, ImageDto>();
        CreateMap<ApartmentForCreationDto, Apartment>();
        CreateMap<AddressForCreationDto, Address>();
        CreateMap<ApartmentForUpdateDto, Apartment>();
        CreateMap<AddressDto, Address>();
        CreateMap<AddressForUpdateDto, Address>().ReverseMap();
    }
}
