﻿using Bookify.Domain.Abstractions;

namespace Bookify.Application.Exceptions;

public sealed record ValidationError : Error
{
    public Error[] Errors { get; }

    public ValidationError(Error[] errors) :
        base("General.Validation", "One or more validation errors occurred", ErrorType.Validation)
    {
        Errors = errors;
    }
}
