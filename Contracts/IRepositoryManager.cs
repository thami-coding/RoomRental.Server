namespace Contracts;

public interface IRepositoryManager
{
    IApartmentRepository Apartment { get; }
    IAddressRepository Address { get; }
    void Save();
}
