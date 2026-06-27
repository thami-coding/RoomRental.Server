using Shared.DataTransferObjects;

namespace Service.Contracts;

public interface IApartmentService
{
    IEnumerable<ApartmentsDto> GetAllApartments(bool trackChanges);
    ApartmentDto GetApartment(Guid apartmentId, bool trackChanges);
    ApartmentDto CreateApartment(ApartmentForCreationDto apartment);
    void DeleteApartment(Guid apartmentId, bool trackChanges);
}
