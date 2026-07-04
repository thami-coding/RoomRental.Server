using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository;

public class AddressRepository : RepositoryBase<Address>, IAddressRepository
{
    public AddressRepository(RepositoryContext repositoryContext)
        : base(repositoryContext) { }

    public async Task<Address> GetAddressAsync(Guid apartmentId, Guid id, bool trackChanges) =>
        await FindByCondition(a => a.ApartmentId.Equals(apartmentId) && a.Id.Equals(id), trackChanges)
        .SingleOrDefaultAsync();

    public void DeleteAddress(Address address) => Delete(address);

}
