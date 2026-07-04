using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository;

public class ApartmentRepository : RepositoryBase<Apartment>, IApartmentRepository
{
    public ApartmentRepository(RepositoryContext repositoryContext)
        : base(repositoryContext) { }

    public void CreateApartment(Apartment apartment) => Create(apartment);

    public async Task<IEnumerable<Apartment>> GetAllApartmentsAsync(bool trackChanges) =>
       await FindAll(trackChanges).Include(a => a.Address)
        .Include(a => a.Images)
        .OrderBy(apartment => apartment.AvailableRooms)
        .ToListAsync();

    public async Task<Apartment> GetApartmentAsync(Guid apartmentId, bool trackChanges) =>
        await FindByCondition(a => a.Id.Equals(apartmentId), trackChanges)
        .Include(a => a.Address)
        .Include(a => a.Images)
        .SingleOrDefaultAsync();

    public void DeleteApartment(Apartment apartment) => Delete(apartment);

}
