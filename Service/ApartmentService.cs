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

        var apartmentDto = _mapper.Map<ApartmentDto>(apartment);
        return apartmentDto;
    }

    public ApartmentDto CreateApartment(ApartmentForCreationDto apartment)
    {
        var apartmentEntity = _mapper.Map<Apartment>(apartment);

        _repository.Apartment.CreateApartment(apartmentEntity);
        _repository.Save();

        var apartmentToReturn = _mapper.Map<ApartmentDto>(apartmentEntity);

        return apartmentToReturn;
    }

    public void DeleteApartment(Guid apartmentId, bool trackChanges)
    {
        var apartment = _repository.Apartment.GetApartment(apartmentId, trackChanges);
        if (apartment is null)
            throw new ApartmentNotFoundException(apartmentId);

        _repository.Apartment.DeleteApartment(apartment);
        _repository.Save();
    }

    public void UpdateApartment(Guid apartmentId, ApartmentForUpdateDto apartmentForUpdate, bool trackChanges)
    {
        var apartmentEntity = _repository.Apartment.GetApartment(apartmentId,trackChanges);
        if (apartmentEntity is null)
            throw new ApartmentNotFoundException(apartmentId);

        _mapper.Map(apartmentForUpdate, apartmentEntity);
        _repository.Save();
    }
}
