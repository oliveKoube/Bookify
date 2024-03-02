using Bookify.Domain.Apartments;
using Bookify.Domain.Shared;

namespace Bookify.Domain.UnitTests.Apartments;

internal static class ApartmentData
{
    public static Apartment Create(Money price, Money? cleaningFee=null) => new(
        Guid.NewGuid(),
        new Name("Test"),
        new Description("Test description"),
        new Address("Country", "City", "ZipCode", "City", "Street"),
        price,
        cleaningFee ?? Money.Zero(),
        []);

}