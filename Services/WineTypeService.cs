using Microsoft.EntityFrameworkCore;
using Sommelio.Data;
using Sommelio.DTO;
using Sommelio.Entities;

namespace Sommelio.Services
{
    public class WineTypeService
    {
        private readonly DataContext _context;

        public WineTypeService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<WineTypeGetDto>> GetWinesAsync()
        {
            var WineTypes = await _context.WineTypes.ToListAsync();
            return WineTypes.Select(wt => new WineTypeGetDto
            {
                Name = wt.Name,
                Color = _context.ColorsBtn.FirstOrDefault(c => c.Id == wt.ColorId).ColorCode
            }).ToList();
        }

        public async Task<Wine> GetWineAsync(int id)
        {
            return await _context.Wines.FirstOrDefaultAsync(w => w.Id == id);
        }

        //    public async Task<Wine> AddWineAsync(Wine wine)
        //    {
        //        _context.Wines.Add(wine);
        //        await _context.SaveChangesAsync();
        //        return wine;
        //    }

        //    public async Task<Wine> UpdateWineAsync(int id, Wine wine)
        //    {
        //        var wineToUpdate = await _context.Wines.FirstOrDefaultAsync(w => w.Id == id);
        //        wineToUpdate.Name = wine.Name;
        //        wineToUpdate.Year = wine.Year;
        //        wineToUpdate.WineTypeId = wine.WineTypeId;
        //        wineToUpdate.TypeAppellationId = wine.TypeAppellationId;
        //        wineToUpdate.CountryId = wine.CountryId;
        //        wineToUpdate.RegionId = wine.RegionId;
        //        wineToUpdate.CepageId = wine.CepageId;
        //        wineToUpdate.Description = wine.Description;
        //        wineToUpdate.Price = wine.Price;
        //        wineToUpdate.Image = wine.Image;
        //        await _context.SaveChangesAsync();
        //        return wineToUpdate;
        //    }

        //    public async Task<Wine> DeleteWineAsync(int id)
        //    {
        //        var wineToDelete = await _context.Wines.FirstOrDefaultAsync(w => w.Id == id);
        //        _context.Wines.Remove(wineToDelete);
        //        await _context.SaveChangesAsync();
        //        return wineToDelete;
        //    }
        //}
    }
}
