using System;

namespace CwkBooking.Api.Services.Abstraction;

public interface IScopedOperation
{
    Guid GetGuid();
}