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

    public async Task<AddressDto> GetAddressAsync(Guid apartmentId, Guid id, bool trackChanges)
    {
        await CheckIfApartmentExists(apartmentId, trackChanges);

        var addressDb = await GetAddressForApartmentAndCheckIfItExists(apartmentId, id, trackChanges);

        var address = _mapper.Map<AddressDto>(addressDb);
        return address;
    }

    public async Task DeleteAddressForApartmentAsync(Guid apartmentId, Guid id, bool trackChanges)
    {
        await CheckIfApartmentExists(apartmentId, trackChanges);

        var addressDb = await GetAddressForApartmentAndCheckIfItExists(apartmentId, id, trackChanges);

        _repository.Address.DeleteAddress(addressDb);
        await _repository.SaveAsync();

    }

    public async Task UpdateAddressForApartmentAsync(Guid apartmentId, Guid id, AddressForUpdateDto addressForUpdate, bool apartmentTrackChanges, bool addressTrackChanges)
    {
        var apartment = await _repository.Apartment.GetApartmentAsync(apartmentId, apartmentTrackChanges);
        await CheckIfApartmentExists(apartmentId, apartmentTrackChanges);

        var addressEntity = await GetAddressForApartmentAndCheckIfItExists(apartmentId, id, addressTrackChanges);

        _mapper.Map(addressForUpdate, addressEntity);
        await _repository.SaveAsync();
    }

    public async Task<(AddressForUpdateDto addressToPatch, Address addressEntity)> GetAddressForPatchAsync(Guid apartmentId, Guid id, bool apartmentTrackChanges, bool addressTrackChanges)
    {
        await CheckIfApartmentExists(apartmentId, apartmentTrackChanges);

        var addressDb = await GetAddressForApartmentAndCheckIfItExists(apartmentId, id, addressTrackChanges);

        var addressToPatch = _mapper.Map<AddressForUpdateDto>(addressDb);

        return (addressToPatch, addressDb);
    }

    public async Task SaveChangesForPatchAsync(AddressForUpdateDto addressToPatch, Address addressEntity)
    {
        _mapper.Map(addressToPatch, addressEntity);
        await _repository.SaveAsync();
    }

    private async Task CheckIfApartmentExists(Guid apartmentId, bool trackChanges)
    {
        var apartment = await _repository.Apartment.GetApartmentAsync(apartmentId, trackChanges);
        if (apartment is null)
            throw new ApartmentNotFoundException(apartmentId);
    }

    private async Task<Address> GetAddressForApartmentAndCheckIfItExists(Guid apartmentId, Guid id, bool trackChanges)
    {
        var apartment = await _repository.Apartment.GetApartmentAsync(apartmentId, trackChanges);
        if (apartment is null)
            throw new ApartmentNotFoundException(apartmentId);

        var addressDb = await _repository.Address.GetAddressAsync(apartmentId, id, trackChanges);
        if (addressDb is null)
            throw new AddressNotFoundException(id);

        return addressDb;
    }
}
