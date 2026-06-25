using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace Service;

internal sealed class ApartmentService : IApartmentService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;
    private readonly IMapper _mapper;

    public ApartmentService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
    {
        _repository = repository;
        _logger = logger;
        _mapper = mapper;
    }

    public IEnumerable<ApartmentsDto> GetAllApartments(bool trackChanges)
    {

        var apartments = _repository.Apartment.GetAllApartments(trackChanges);
        var aprtmentsDto = _mapper.Map<IEnumerable<ApartmentsDto>>(apartments);

        return aprtmentsDto;
    }

    public ApartmentDto GetApartment(Guid id, bool trackChanges)
    {
        var apartment = _repository.Apartment.GetApartment(id, trackChanges);
        if (apartment is null)
            throw new ApartmentNotFoundException(id);

        var apartmentDto = _mapper.Map<ApartmentDto>(null);
        return apartmentDto;
    }
}
