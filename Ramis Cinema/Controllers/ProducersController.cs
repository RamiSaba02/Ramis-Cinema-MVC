using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ramis_Cinema.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Ramis_Cinema.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDbContext _context;

        public ProducersController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allProducers = await _context.Producers.ToListAsync();
            return View(allProducers);
        }
    }
}
