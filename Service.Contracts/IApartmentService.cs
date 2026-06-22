using Shared.DataTransferObjects;

namespace Service.Contracts;

public interface IApartmentService
{
    IEnumerable<ApartmentDto> GetAllApartments(bool trackChanges);
}
