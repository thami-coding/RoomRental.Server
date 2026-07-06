namespace Service.Contracts;

public interface IServiceManager
{
    IApartmentService ApartmentService { get; }
    IAddressService AddressService { get; }
    IAuthenticationService AuthenticationService { get; }
}
