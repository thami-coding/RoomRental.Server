using Shared.DataTransferObjects;
using Shared.RequestFeatures;

namespace Service.Contracts;

public interface IApartmentService
{
    Task<(IEnumerable<ApartmentDto> apartments, MetaData metaData)> GetAllApartmentsAsync(ApartmentParameters apartmentParameters,
        bool trackChanges);
    Task<ApartmentDto> GetApartmentAsync(Guid apartmentId, bool trackChanges);
    Task<ApartmentDto> CreateApartmentAsync(ApartmentForCreationDto apartment);
    Task DeleteApartmentAsync(Guid apartmentId, bool trackChanges);
    Task UpdateApartmentAsync(Guid apartmentId, ApartmentForUpdateDto apartmentForUpdateDto, bool trackChanges);
}
