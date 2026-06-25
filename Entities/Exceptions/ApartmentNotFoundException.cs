namespace Entities.Exceptions;

public sealed class ApartmentNotFoundException : NotFoundException
{
    public ApartmentNotFoundException(Guid apartmentId) : base($"The apartment with id: {apartmentId} doesn't exist in the database")
    { }
}
