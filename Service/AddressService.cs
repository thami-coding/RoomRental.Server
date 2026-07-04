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

    public async Task<AddressDto> GetAddressAsync(Guid addressId, Guid id, bool trackChanges)
    {
        var apartment = await _repository.Apartment.GetApartmentAsync(addressId, trackChanges);
        if (apartment is null)
            throw new ApartmentNotFoundException(addressId);

        var addressDb = await _repository.Address.GetAddressAsync(addressId, id, trackChanges);
        if (addressDb is null)
            throw new AddressNotFoundException(id);

        var address = _mapper.Map<AddressDto>(addressDb);
        return address;
    }

    public async Task  DeleteAddressForApartmentAsync(Guid apartmentId, Guid id, bool trackChanges)
    {
        var apartment = await _repository.Apartment.GetApartmentAsync(apartmentId, trackChanges);
        if (apartment is null)
            throw new ApartmentNotFoundException(apartmentId);

        var addressForApartment = await _repository.Address.GetAddressAsync(apartmentId, id, trackChanges);
        if (addressForApartment is null)
            throw new AddressNotFoundException(id);

        _repository.Address.DeleteAddress(addressForApartment);
        await _repository.SaveAsync();

    }

    public async Task  UpdateAddressForApartmentAsync(Guid apartmentId, Guid id, AddressForUpdateDto addressForUpdate, bool apartmentTrackChanges, bool addressTrackChanges)
    {
        var apartment = await _repository.Apartment.GetApartmentAsync(apartmentId, apartmentTrackChanges);
        if (apartment is null)
            throw new ApartmentNotFoundException(apartmentId);

        var addressEntity = await _repository.Address.GetAddressAsync(apartmentId, id, addressTrackChanges);
        if (addressEntity is null)
            throw new AddressNotFoundException(id);

        _mapper.Map(addressForUpdate, addressEntity);
        await _repository.SaveAsync();
    }

    public async Task<(AddressForUpdateDto addressToPatch, Address addressEntity)> GetAddressForPatchAsync(Guid apartmentId, Guid id, bool apartmentTrackChanges, bool addressTrackChanges)
    {
        var apartment = await _repository.Apartment.GetApartmentAsync(apartmentId, apartmentTrackChanges);
        if (apartment is null)
            throw new ApartmentNotFoundException(apartmentId);

        var addressEntity = await _repository.Address.GetAddressAsync(apartmentId, id, addressTrackChanges);
        if (addressEntity is null)
            throw new AddressNotFoundException(id);

        var addressToPatch = _mapper.Map<AddressForUpdateDto>(addressEntity);

        return (addressToPatch, addressEntity);
    }

    public async Task SaveChangesForPatchAsync(AddressForUpdateDto addressToPatch, Address addressEntity)
    {
        _mapper.Map(addressToPatch, addressEntity);
        await _repository.SaveAsync();
    }
}
