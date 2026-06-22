using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository;

public class ApartmentRepository : RepositoryBase<Apartment>, IApartmentRepository
{
    public ApartmentRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    { }

    public IEnumerable<Apartment> GetAllApartments(bool trackChanges) =>
        FindAll(trackChanges).Include(a => a.Address).OrderBy(apartment => apartment.AvailableRooms).ToList();
}
