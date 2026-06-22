using AutoMapper;
using Contracts;
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

    public IEnumerable<ApartmentDto> GetAllApartments(bool trackChanges)
    {
        try
        {
            var apartments = _repository.Apartment.GetAllApartments(trackChanges);
            var aprtmentsDto = _mapper.Map<IEnumerable<ApartmentDto>>(apartments);

            return aprtmentsDto;
        }
        catch (Exception ex)
        {

            _logger.LogError($"Something went wrong in the {nameof(GetAllApartments)} service method {ex}");
            throw;
        }
    }
}
