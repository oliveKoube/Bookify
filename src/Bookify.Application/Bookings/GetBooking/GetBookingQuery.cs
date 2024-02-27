using Bookify.Application.Caching;

namespace Bookify.Application.Bookings.GetBooking;

public sealed record GetBookingQuery(Guid BookingId) : ICachedQuery<BookingResponse>
{
    public string CacheKey => $"booking-{BookingId}";
    public TimeSpan? Expiration => null;
}
