using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository;

public class ApartmentRepository : RepositoryBase<Apartment>, IApartmentRepository
{
    public ApartmentRepository(RepositoryContext repositoryContext)
        : base(repositoryContext) { }

    public void CreateApartment(Apartment apartment) => Create(apartment);

    public IEnumerable<Apartment> GetAllApartments(bool trackChanges) =>
        FindAll(trackChanges).Include(a => a.Address)
        .Include(a => a.Images)
        .OrderBy(apartment => apartment.AvailableRooms)
        .ToList();

    public Apartment GetApartment(Guid apartmentId, bool trackChanges) =>
        FindByCondition(a => a.Id.Equals(apartmentId), trackChanges)
        .Include(a => a.Address)
        .Include(a => a.Images)
        .SingleOrDefault();

    public void DeleteApartment(Apartment apartment) => Delete(apartment);

}
