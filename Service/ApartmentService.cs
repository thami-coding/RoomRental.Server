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

    public async Task<IEnumerable<ApartmentsDto>> GetAllApartmentsAsync(bool trackChanges)
    {
        var apartments = await _repository.Apartment.GetAllApartmentsAsync(trackChanges);
        var aprtmentsDto = _mapper.Map<IEnumerable<ApartmentsDto>>(apartments);

        return aprtmentsDto;
    }

    public async Task<ApartmentDto> GetApartmentAsync(Guid id, bool trackChanges)
    {
        var apartment = await GetApartmentAndCheckIfItExists(id, trackChanges);

        var apartmentDto = _mapper.Map<ApartmentDto>(apartment);
        return apartmentDto;
    }

    public async Task<ApartmentDto> CreateApartmentAsync(ApartmentForCreationDto apartment)
    {
        var apartmentEntity = _mapper.Map<Apartment>(apartment);

        _repository.Apartment.CreateApartment(apartmentEntity);
        await _repository.SaveAsync();

        var apartmentToReturn = _mapper.Map<ApartmentDto>(apartmentEntity);

        return apartmentToReturn;
    }

    public async Task DeleteApartmentAsync(Guid apartmentId, bool trackChanges)
    {
        var apartment = await GetApartmentAndCheckIfItExists(apartmentId, trackChanges);

        _repository.Apartment.DeleteApartment(apartment);
        await _repository.SaveAsync();
    }

    public async Task UpdateApartmentAsync(Guid apartmentId, ApartmentForUpdateDto apartmentForUpdate, bool trackChanges)
    {
        var apartment = await GetApartmentAndCheckIfItExists(apartmentId, trackChanges);

        _mapper.Map(apartmentForUpdate, apartment);
        await _repository.SaveAsync();
    }

    private async Task<Apartment> GetApartmentAndCheckIfItExists(Guid id, bool trackChanges)
    {
        var apartment = await _repository.Apartment.GetApartmentAsync(id, trackChanges);
        if (apartment is null)
            throw new ApartmentNotFoundException(id);
        return apartment;
    }
}
