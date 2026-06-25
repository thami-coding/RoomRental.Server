using Entities.Models;

namespace Contracts;

public interface IAddressRepository
{
    IEnumerable<Address> GetAddress(Guid addressId, Guid id, bool trackChanges);
}
