using CwkBooking.Api.Services.Abstractions;
using System;

namespace CwkBooking.Api.Services;
 public class ScopedOperation : IScopedOperation
 {
    public Guid GetGuid()
    {
        return GetGuid.NewGuid()
    }
 }