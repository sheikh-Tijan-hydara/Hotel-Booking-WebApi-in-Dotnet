using CwkBooking.Api.Services.Abstractions;
using System;

namespace CwkBooking.Api.Services;
 public class SingletonOperation : ISingletonOperation
 {
    public Guid GetGuid()
    {
        return GetGuid.NewGuid()
    }
 }