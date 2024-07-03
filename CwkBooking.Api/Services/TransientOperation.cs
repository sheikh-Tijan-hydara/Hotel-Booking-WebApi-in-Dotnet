using CwkBooking.Api.Services.Abstractions;
using System;

namespace CwkBooking.Api.Services;
 public class TransientOperation : ITransientOperation
 {
    public Guid GetGuid()
    {
        return GetGuid.NewGuid()
    }
 }