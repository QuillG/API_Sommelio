using Microsoft.EntityFrameworkCore;
using Sommelio.Data;
using Sommelio.DTO;
using Sommelio.Entities;
using System.Dynamic;
using System.Globalization;

namespace Sommelio.Services
{
    public class EventsService
    {
        private readonly DataContext _context;

        public EventsService(DataContext context)
        {
            _context = context;
        }

        public async Task<EventDto> PostEventAsync(EventDto eventDto)
        {
            var company = await _context.Companies.FirstOrDefaultAsync(c => c.Id == eventDto.CompanyId);
            var address = await _context.Addresses.FirstOrDefaultAsync(a => a.Id == eventDto.AddressId);


            var newEvent = new Events
            {
                CompanyId = company.Id,
                AddressId = address.Id,
                Name = eventDto.Name,
                Description = eventDto.Description,
                PictureUrl = eventDto.PictureUrl,
                StartDate = eventDto.StartDate,
                EndDate = eventDto.EndDate,
                Address = address,
                Company = company,

            };

            _context.Events.Add(newEvent);
            await _context.SaveChangesAsync();
            return eventDto;
        }

        public async Task<List<ResumeEventDto>> GetResumeEventsAsync()
        {
            var events = await _context.Events.ToListAsync();
            var resumeEvents = new List<ResumeEventDto>();

            foreach (var e in events)
            {
                var address = await _context.Addresses.FirstOrDefaultAsync(a => a.Id == e.AddressId); // Assume AddressId is the correct foreign key
                var companyName = e.CompanyId != null ? (await _context.Companies.FirstOrDefaultAsync(c => c.Id == e.CompanyId)).Name : "Nom de l'entreprise non disponible";
                if (e.PictureUrl == null || e.PictureUrl == "string") { 
                    e.PictureUrl = null;
                } else
                {
                    e.PictureUrl = e.PictureUrl;
                }

                var resumeEvent = new ResumeEventDto
                {
                    Id = e.Id,
                    Description = e.Description,
                    Date = ConvertDate(e.StartDate),
                    Location = ConvertLocation(address),
                    PictureUrl = e.PictureUrl,
                    CompanyName = companyName,
                };

                resumeEvents.Add(resumeEvent);
            }

            return resumeEvents;
        }

        public string ConvertDate(DateTime startDate)
        {
            // Retourne la date en format dd MMMM avec la premiere lettre du mois en majuscule en utilisant la culture française
            var date = startDate.ToString("dd MMMM", CultureInfo.CreateSpecificCulture("fr-FR"));
            // le jour + la première lettre du MMMM en majuscule 
            var mois = char.ToUpper(date[3]) + date.Substring(4);
            return $"{date.Substring(0, 2)} {mois}";


        }

        public string ConvertLocation(Address? address)
        {
            // Vérifie si l'adresse est null et retourne une chaîne vide ou un message approprié
            if (address == null) return "Adresse non disponible";

            // Retourne la localisation en format "Code Postal, Ville"
            var codePostal = address.ZipCode;
            var city = address.City;
            //la premiere lettre de la ville en majuscule
            city = char.ToUpper(city[0]) + city.Substring(1);
            return $"{codePostal} {city}";
        }

    }

}








