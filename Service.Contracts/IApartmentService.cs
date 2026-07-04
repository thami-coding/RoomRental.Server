using Shared.DataTransferObjects;

namespace Service.Contracts;

public interface IApartmentService
{
    Task<IEnumerable<ApartmentsDto>> GetAllApartmentsAsync(bool trackChanges);
    Task<ApartmentDto> GetApartmentAsync(Guid apartmentId, bool trackChanges);
    Task<ApartmentDto> CreateApartmentAsync(ApartmentForCreationDto apartment);
    Task DeleteApartmentAsync(Guid apartmentId, bool trackChanges);
    Task UpdateApartmentAsync(Guid apartmentId, ApartmentForUpdateDto apartmentForUpdateDto, bool trackChanges);
}
