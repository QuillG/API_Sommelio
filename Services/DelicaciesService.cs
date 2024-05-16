using Microsoft.EntityFrameworkCore;
using Sommelio.Data;
using Sommelio.DTO;

namespace Sommelio.Services
{
    public class DelicaciesService
    {
        private readonly DataContext _context;

        public DelicaciesService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<DelicaciesGetDto>> GetPrincipalDelicaciesAsync()
        {
            //rechercher les delicaces ou les parentid est null
            var Delicacies = await _context.Delicacies.Where(d => d.parentId == null).ToListAsync();
            return Delicacies.Select(d => new DelicaciesGetDto
            {
                Name = d.Name,
                Color = _context.ColorsBtn.FirstOrDefault(c => c.Id == d.ColorId).ColorCode
            }).ToList();
        }


        public async Task<List<DelicaciesGetDto>> GetDelicaciesbyParentAsync(String name)
        {
            //rechercher l'id de la delicace parent
            var parentId = await _context.Delicacies.Where(d => d.Name == name).ToListAsync();
            //rechercher les delicaces ou les parentid est l'id de la delicace parent
            var Delicacies = await _context.Delicacies.Where(d => d.parentId == parentId[0].Id).ToListAsync();
            return Delicacies.Select(d => new DelicaciesGetDto
            {
                Name = d.Name,
                Color = _context.ColorsBtn.FirstOrDefault(c => c.Id == d.ColorId).ColorCode
            }).ToList();
        }

        //public async Task<Delicacies> GetDelicacyAsync(int id)
        //{
        //    return await _context.Delicacies.FirstOrDefaultAsync(d => d.Id == id);
        //}

        //public async Task<Delicacies> AddDelicacyAsync(Delicacies delicacy)
        //{
        //    _context.Delicacies.Add(delicacy);
        //    await _context.SaveChangesAsync();
        //    return delicacy;
        //}

        //public async Task<Delicacies> UpdateDelicacyAsync(int id, Delicacies delicacy)
        //{
        //    var delicacyToUpdate = await _context.Delicacies.FirstOrDefaultAsync(d => d.Id == id);
        //    delicacyToUpdate.Name = delicacy.Name;
        //    delicacyToUpdate.Description = delicacy.Description;
        //    delicacyToUpdate.Price = delicacy.Price;
        //    delicacyToUpdate.Image = delicacy.Image;
        //    await _context.SaveChangesAsync();
        //    return delicacyToUpdate;
        //}

        //public async Task<Delicacies> DeleteDelicacyAsync(int id)
        //{
        //    var delicacyToDelete = await _context.Delicacies.FirstOrDefaultAsync(d => d.Id == id);
        //    _context.Delicacies.Remove(delicacyToDelete);
        //    await _context.SaveChangesAsync();
        //    return delicacyToDelete;
        //}
    }
}
