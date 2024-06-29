using CwkBooking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CwkBooking.Api
{
    public class DataSource
    {
        public DataSource()
        {
            Hotels = GetHotels();
        }


        public List<Hotel> Hotels {get; set;}


        private List<Hotel> GetHotels()
        {
            return new List<Hotel>
            {
                new Hotel
                {
                    HotelId = 1,
                    HotelName = "Hotel 1",
                    HotelStars = 3,
                    HotelAddress = "Address 1",
                    HotelCity = "City 1",
                    HotelCountry = "Country 1",
                    HotelDescription = "Description 1",

                },

                new Hotel
                {
                    HotelId = 2,
                    HotelName = "Hotel 2",
                    HotelStars = 4,
                    HotelAddress = "Address 2",
                    HotelCity = "City 2",
                    HotelCountry = "Country 2",
                    HotelDescription = "Description 2",

                }
            };
        }
    }
}