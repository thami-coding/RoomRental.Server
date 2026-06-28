using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace Service;

internal sealed class AddressService : IAddressService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;
    private readonly IMapper _mapper;


    public AddressService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
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

    public void UpdateAddressForApartment(Guid apartmentId, Guid id, AddressForUpdateDto addressForUpdate, bool apartmentTrackChanges, bool addressTrackChanges)
    {
        var apartment = _repository.Apartment.GetApartment(apartmentId, apartmentTrackChanges);
        if (apartment is null)
            throw new ApartmentNotFoundException(apartmentId);

        var addressEntity = _repository.Address.GetAddress(apartmentId, id, addressTrackChanges);
        if (addressEntity is null)
            throw new AddressNotFoundException(id);

        _mapper.Map(addressForUpdate, addressEntity);
        _repository.Save();
    }

    public (AddressForUpdateDto addressToPatch, Address addressEntity) GetAddressForPatch(Guid apartmentId, Guid id, bool apartmentTrackChanges, bool addressTrackChanges)
    {
        var apartment = _repository.Apartment.GetApartment(apartmentId, apartmentTrackChanges);
        if (apartment is null)
            throw new ApartmentNotFoundException(apartmentId);

        var addressEntity = _repository.Address.GetAddress(apartmentId, id, addressTrackChanges);
        if (addressEntity is null)
            throw new AddressNotFoundException(id);

        var addressToPatch = _mapper.Map<AddressForUpdateDto>(addressEntity);

        return (addressToPatch, addressEntity);
    }

    public void SaveChangesForPatch(AddressForUpdateDto addressToPatch, Address addressEntity)
    {
        _mapper.Map(addressToPatch, addressEntity);
        _repository.Save();
    }
}
