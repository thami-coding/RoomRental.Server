using Contracts;

namespace Repository;

public sealed class RepositoryManager : IRepositoryManager
{
    private readonly RepositoryContext _repositoryContext;
    private readonly Lazy<IApartmentRepository> _apartmentRepository;
    private readonly Lazy<IAddressRepository> _addressRepository;

    public RepositoryManager(RepositoryContext repositoryContext)
    {
        _repositoryContext = repositoryContext;
        _addressRepository = new Lazy<IAddressRepository>(() => new AddressRepository(repositoryContext));
        _apartmentRepository = new Lazy<IApartmentRepository>(() => new ApartmentRepository(repositoryContext));
    }

    public IApartmentRepository Apartment => _apartmentRepository.Value;
    public IAddressRepository Address => _addressRepository.Value;

    public void Save() => _repositoryContext.SaveChanges();
}
