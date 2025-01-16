using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Bookings;

public static class BookingErrors
{
    public static readonly Error NotFound = new(
        "Booking.Found",
        "The booking with the specified identifier was not found",
        ErrorType.NotFound);

    public static readonly Error Overlap = new(
        "Booking.Overlap",
        "The current booking is overlapping with an existing one",
        ErrorType.Conflict);

    public static readonly Error NotReserved = new(
        "Booking.NotReserved",
        "The booking is not pending",
        ErrorType.Problem);

    public static readonly Error NotConfirmed = new(
        "Booking.NotReserved",
        "The booking is not confirmed",
        ErrorType.Problem);

    public static readonly Error AlreadyStarted = new(
        "Booking.AlreadyStarted",
        "The booking has already started",
        ErrorType.Problem);
}
