using Entities.Models;

namespace Contracts;

public interface IApartmentRepository
{
    Task<IEnumerable<Apartment>> GetAllApartmentsAsync(bool trackChanges);
    Task<Apartment> GetApartmentAsync(Guid id, bool trackChanges);
    void CreateApartment(Apartment apartment);
    void DeleteApartment(Apartment apartment);
   
}
