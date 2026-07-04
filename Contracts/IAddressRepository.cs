using Entities.Models;

namespace Contracts;

public interface IAddressRepository
{
   Task<Address> GetAddressAsync(Guid addressId, Guid id, bool trackChanges);
    void DeleteAddress(Address address);
}
