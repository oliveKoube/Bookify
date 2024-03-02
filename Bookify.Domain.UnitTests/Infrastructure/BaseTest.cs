﻿using Bookify.Domain.Abstractions;
using FluentAssertions;

namespace Bookify.Domain.UnitTests.Infrastructure;

public abstract class BaseTest
{
    public static T AsserDomainEventWasPublished<T>(Entity entity)
        where T : IDomainEvent
    {
        var domainEvent = entity
            .GetDomainEvents()
            .OfType<T>()
            .SingleOrDefault();

        if(domainEvent is null)
        {
            throw new Exception($"No domain event of type {typeof(T).Name} was published");
        }

        return domainEvent;
    }
}