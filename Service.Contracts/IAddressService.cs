using Entities.Models;
using Shared.DataTransferObjects;
using System.Net;

namespace Service.Contracts;

public interface IAddressService
{
    AddressDto GetAddress(Guid addressId, Guid id, bool trackChanges);
    void DeleteAddressForApartment(Guid apartmentId, Guid id, bool trackChanges);
    void UpdateAddressForApartment(Guid apartmentId, Guid id, AddressForUpdateDto addressForUpdate,
        bool apartmentTrackChanges, bool addresssTrackChanges);

    (AddressForUpdateDto addressToPatch, Address addressEntity) GetAddressForPatch(
        Guid apartmentId, Guid id, bool apartmentTrackChanges, bool addressTrackChanges);

    void SaveChangesForPatch(AddressForUpdateDto addressToPatch, Address addressEntity);

}
