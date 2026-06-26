using Shared.DataTransferObjects;
using System.Net;

namespace Service.Contracts;

public interface IAddressService
{
    AddressDto GetAddress(Guid addressId, Guid id, bool trackChanges);
    void DeleteAddressForApartment(Guid apartmentId, Guid id, bool trackChanges);
}
