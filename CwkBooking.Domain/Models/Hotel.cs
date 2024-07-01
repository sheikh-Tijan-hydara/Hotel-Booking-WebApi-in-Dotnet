using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwkBooking.Domain.Models;
public class Hotel
{
    public int HotelId { get; set; }
    public string HotelName { get; set; }
    public int HotelStars { get; set; }
    public string HotelAddress { get; set; }
    public string HotelCity { get; set; }
    public string HotelCountry { get; set; }
    public List<Room>? Rooms { get; set; }
    public string HotelDescription { get; set; }
}