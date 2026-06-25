namespace Entities.Exceptions;

public sealed class AddressNotFoundException : NotFoundException
{
    public AddressNotFoundException(Guid addressId)
        : base($"Address with id: {addressId} deosn't exist in the database") { }
}
