using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Shared.RequestFeatures;

namespace Repository;

public class ApartmentRepository : RepositoryBase<Apartment>, IApartmentRepository
{
    public ApartmentRepository(RepositoryContext repositoryContext)
        : base(repositoryContext) { }

    public void CreateApartment(Apartment apartment) => Create(apartment);

    public async Task<PagedList<Apartment>> GetAllApartmentsAsync(ApartmentParameters apartmentParameters,
        bool trackChanges)
    {
        var apartmernts = await FindAll(trackChanges)
            .OrderBy(a => a.Price)
             .ToListAsync();

        return PagedList<Apartment>
            .ToPagedList(apartmernts, apartmentParameters.PageNumber, apartmentParameters.PageSize);
    }


    public async Task<Apartment> GetApartmentAsync(Guid apartmentId, bool trackChanges) =>
        await FindByCondition(a => a.Id.Equals(apartmentId), trackChanges)
        .Include(a => a.Address)
        .Include(a => a.Images)
        .SingleOrDefaultAsync();

    public void DeleteApartment(Apartment apartment) => Delete(apartment);


}
