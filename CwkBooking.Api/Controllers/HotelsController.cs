using CwkBooking.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CwkBooking.Api.Controllers
{
    // this will have an endpoint route of /api/hotels
    [ApiController]
    [Route("api/[controller]")]
    public class HotelsController : Controller //inherits from Controller to make our class a controller
    {
        private readonly DataSource _dataSource;
        public HotelsController(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        // will execute if the request is a get request to /api/hotels
        [HttpGet]
        public IActionResult GetAllHotels()
        {
            var HotelsList = _dataSource.Hotels;
            return Ok(HotelsList);
        }


        // will execute if the request is a get request to /api/hotels/{id}
        [HttpGet("{id}")]
        public IActionResult GetHotelById(int id)
        {
            var HotelsList = _dataSource.Hotels;
            var hotel = HotelsList.FirstOrDefault(x => x.HotelId == id);
            if (hotel == null)
            {
                return NotFound("Hotel not found");
            }
            return Ok(hotel);
        }


        // will execute if the request is a post request to /api/hotels
        [HttpPost]
        public IActionResult CreateHotel([FromBody] Hotel hotel)
        {
            var HotelsList = _dataSource.Hotels;
            HotelsList.Add(hotel);
            return CreatedAtAction(nameof(GetHotelById), new { id = hotel.HotelId }, hotel);
        }


        // will execute if the request is a put request to /api/hotels/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateHotel(int id, [FromBody] Hotel hotel)
        {
            var HotelsList = _dataSource.Hotels;
            var hotelToUpdate = HotelsList.FirstOrDefault(x => x.HotelId == id);
            if (hotelToUpdate == null)
            {
                return NotFound("Hotel not found");
            }
            hotelToUpdate.HotelName = hotel.HotelName;
            hotelToUpdate.HotelStars = hotel.HotelStars;
            hotelToUpdate.HotelAddress = hotel.HotelAddress;
            hotelToUpdate.HotelCity = hotel.HotelCity;
            hotelToUpdate.HotelCountry = hotel.HotelCountry;
            hotelToUpdate.HotelDescription = hotel.HotelDescription;
            return NoContent();
        }


        // will execute if the request is a delete request to /api/hotels/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteHotel(int id)
        {
            var HotelsList = _dataSource.Hotels;
            var hotelToDelete = HotelsList.FirstOrDefault(x => x.HotelId == id);
            if (hotelToDelete == null)
            {
                return NotFound("Hotel not found");
            }
            HotelsList.Remove(hotelToDelete);
            return NoContent();
        }


    }
}