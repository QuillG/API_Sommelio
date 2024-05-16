using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sommelio.Data;
using Sommelio.Entities;

namespace Sommelio.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AddressController : Controller
    {
        private readonly DataContext _context;

        public AddressController(DataContext context) { _context = context; }

        [HttpGet]
        public async Task<ActionResult<List<Address>>> GetAllAddresses()
        {
            var addresses = await _context.Addresses.ToListAsync();

            return Ok(addresses);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Address>> GetAddressById(int id)
        {
            var address = await _context.Addresses.FindAsync(id);

            if (address == null)
            {
                return NotFound("Address not found");
            }

            return Ok(address);
        }

        [HttpPost]
        public async Task<ActionResult<Address>> AddAddress(Address address)
        {
            _context.Addresses.Add(address);
            await _context.SaveChangesAsync();

            return Ok(await _context.Addresses.ToListAsync());
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Address>> UpdateAddress(int id, Address address)
        {
            var addressToUpdate = await _context.Addresses.FindAsync(id);

            if (addressToUpdate == null)
            {
                return NotFound("Address not found");
            }

            addressToUpdate.Street = address.Street;
            addressToUpdate.City = address.City;
            addressToUpdate.ZipCode = address.ZipCode;
            addressToUpdate.GpsCoordinates = address.GpsCoordinates;


            await _context.SaveChangesAsync();

            return Ok(addressToUpdate);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Address>> DeleteAddress(int id)
        {
            var addressToDelete = await _context.Addresses.FindAsync(id);

            if (addressToDelete == null)
            {
                return NotFound("Address not found");
            }

            _context.Addresses.Remove(addressToDelete);
            await _context.SaveChangesAsync();

            return Ok(await _context.Addresses.ToListAsync());
        }
    }
}

