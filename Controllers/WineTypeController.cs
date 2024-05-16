using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sommelio.Data;
using Sommelio.DTO;
using Sommelio.Entities;
using Sommelio.Services;

namespace Sommelio.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class WineTypeController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly WineTypeService _wineTypeService;

        public WineTypeController(DataContext context, WineTypeService wineTypeService)
        {
            _context = context;
            _wineTypeService = wineTypeService;
        }

        [HttpGet]
        public async Task<ActionResult<List<WineTypeGetDto>>> GetWineTypes()
        {
            var wineTypes = await _wineTypeService.GetWinesAsync();
            return Ok(wineTypes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetWineType(int id)
        {
            var wineType = await _context.WineTypes.FirstOrDefaultAsync(wt => wt.Id == id);
            return Ok(wineType);
        }

        [HttpPost]
        public async Task<ActionResult> AddWineType([FromBody] WineType wineType)
        {
            _context.WineTypes.Add(wineType);
            await _context.SaveChangesAsync();
            return Ok(wineType);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateWineType(int id, [FromBody] WineType wineType)
        {
            var wineTypeToUpdate = await _context.WineTypes.FirstOrDefaultAsync(wt => wt.Id == id);
            wineTypeToUpdate.Name = wineType.Name;
            wineTypeToUpdate.ColorId = wineType.ColorId;
            await _context.SaveChangesAsync();
            return Ok(wineTypeToUpdate);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteWineType(int id)
        {
            var wineTypeToDelete = await _context.WineTypes.FirstOrDefaultAsync(wt => wt.Id == id);
            _context.WineTypes.Remove(wineTypeToDelete);
            await _context.SaveChangesAsync();
            return Ok(wineTypeToDelete);
        }
    }
}
