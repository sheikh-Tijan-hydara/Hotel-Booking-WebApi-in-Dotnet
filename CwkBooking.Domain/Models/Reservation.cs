using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwkBooking.Domain.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public Room RoomId { get; set; }
        public DateTime? CheckIn { get; set; }
        public DateTime? CheckOut { get; set; }
        public string Customer { get; set; }
    }
}