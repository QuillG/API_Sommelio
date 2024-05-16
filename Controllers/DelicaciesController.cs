using Microsoft.AspNetCore.Mvc;
using Sommelio.Data;
using Sommelio.DTO;
using Sommelio.Services;

namespace Sommelio.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DelicaciesController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly DelicaciesService _delicaciesService;

        public DelicaciesController(DataContext context, DelicaciesService delicaciesService)
        {
            _context = context;
            _delicaciesService = delicaciesService;
        }

        [HttpGet("Principal")]
        public async Task<ActionResult<List<DelicaciesGetDto>>> GetPrincipalDelicacies()
        {
            var delicacies = await _delicaciesService.GetPrincipalDelicaciesAsync();
            return Ok(delicacies);
        }

        [HttpGet("ParentName")]
        public async Task<ActionResult> GetDelicaciesbyParent(String name)
        {
            var delicacies = await _delicaciesService.GetDelicaciesbyParentAsync(name);
            return Ok(delicacies);
        }

    }
}
