using AutoMapper;
using Contracts;
using Service.Contracts;

namespace Service;

public sealed class ServiceManager : IServiceManager
{
    private readonly Lazy<IApartmentService> _apartmentService;
    private readonly Lazy<IAddressService> _addressService;

    public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
    {
        _apartmentService = new Lazy<IApartmentService>(() => new ApartmentService(repositoryManager, logger, mapper));
        _addressService = new Lazy<IAddressService>(() => new AddressService(repositoryManager, logger, mapper));
    }
    public IApartmentService ApartmentService => _apartmentService.Value;
    public IAddressService AddressService => _addressService.Value;
}
