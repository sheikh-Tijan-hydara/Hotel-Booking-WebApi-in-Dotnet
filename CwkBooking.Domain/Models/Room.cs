using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwkBooking.Domain.Models
{
    public class Room
    {
        public int RoomId { get; set; }
        public int RoomNumber { get; set; }
        public double RoomSurface { get; set; }
        public int RoomBeds { get; set; }
        public double RoomPrice { get; set; }
        public bool RoomAvailable { get; set; }
        public bool RoomNeedsRepair { get; set; }
    }
}