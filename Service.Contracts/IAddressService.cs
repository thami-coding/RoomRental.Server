using Entities.Models;
using Shared.DataTransferObjects;
using System.Net;

namespace Service.Contracts;

public interface IAddressService
{
    Task<AddressDto> GetAddressAsync(Guid addressId, Guid id, bool trackChanges);
    Task DeleteAddressForApartmentAsync(Guid apartmentId, Guid id, bool trackChanges);
    Task UpdateAddressForApartmentAsync(Guid apartmentId, Guid id, AddressForUpdateDto addressForUpdate,
        bool apartmentTrackChanges, bool addresssTrackChanges);

    Task<(AddressForUpdateDto addressToPatch, Address addressEntity)> GetAddressForPatchAsync(
        Guid apartmentId, Guid id, bool apartmentTrackChanges, bool addressTrackChanges);

    Task SaveChangesForPatchAsync(AddressForUpdateDto addressToPatch, Address addressEntity);

}
