using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace Service;

internal sealed class AddressService : IAddressService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;
    private readonly IMapper _mapper;


    public AddressService(IRepositoryManager repository, ILoggerManager logger,IMapper mapper)
    {
        _repository = repository;
        _logger = logger;
        _mapper = mapper;
    }

    public AddressDto GetAddress(Guid addressId, Guid id, bool trackChanges)
    {
        var apartment = _repository.Apartment.GetApartment(addressId, trackChanges);
        if (apartment is null)
            throw new ApartmentNotFoundException(addressId);

        var addressDb = _repository.Address.GetAddress(addressId, id, trackChanges);
        if (addressDb is null)
            throw new AddressNotFoundException(id);

        var address = _mapper.Map<AddressDto>(addressDb);
        return address;
    }

    public void DeleteAddressForApartment(Guid apartmentId, Guid id, bool trackChanges)
    {
        var apartment = _repository.Apartment.GetApartment(apartmentId, trackChanges);
        if (apartment is null)
            throw new ApartmentNotFoundException(apartmentId);

        var addressForApartment = _repository.Address.GetAddress(apartmentId, id, trackChanges);
        if (addressForApartment is null)
            throw new AddressNotFoundException(id);

        _repository.Address.DeleteAddress(addressForApartment);
        _repository.Save();

    }
}
