using Contracts;
using Entities.Models;

namespace Repository;

public class AddressRepository : RepositoryBase<Address>, IAddressRepository
{
    public AddressRepository(RepositoryContext repositoryContext)
        : base(repositoryContext) { }


    public Address GetAddress(Guid apartmentId, Guid id, bool trackChanges) =>
        FindByCondition(a => a.ApartmentId.Equals(apartmentId) && a.Id.Equals(id), trackChanges)
        .SingleOrDefault();


}
