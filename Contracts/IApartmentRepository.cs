using Entities.Models;
using Shared.RequestFeatures;

namespace Contracts;

public interface IApartmentRepository
{
    Task<PagedList<Apartment>> GetAllApartmentsAsync(ApartmentParameters apartmentParameters, bool trackChanges);
    Task<Apartment> GetApartmentAsync(Guid id, bool trackChanges);
    void CreateApartment(Apartment apartment);
    void DeleteApartment(Apartment apartment);
   
}
