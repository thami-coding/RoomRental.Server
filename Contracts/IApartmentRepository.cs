using Entities.Models;

namespace Contracts;

public interface IApartmentRepository
{
    IEnumerable<Apartment> GetAllApartments(bool trackChanges);
    Apartment GetApartment(Guid id, bool trackChanges);
    void CreateApartment(Apartment apartment);
}
