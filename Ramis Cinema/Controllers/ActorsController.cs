using Microsoft.AspNetCore.Mvc;
using Ramis_Cinema.Data;
using Ramis_Cinema.Data.Services;
using Ramis_Cinema.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Ramis_Cinema.Controllers
{
    public class ActorsController : Controller
    {

        private readonly IActorsService _context;
        public ActorsController(IActorsService context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _context.GetAllAsync();
            return View(data);
        }


        //Hämta: Actors och skapa
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name,ImgURL,Desc")]Actor actor)
        {
            if(!ModelState.IsValid)
            {

                return View(actor);
            }
            await _context.AddAsync(actor);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Empty(int id)
        {
            var actorDetail = await _context.GetByIdAsync(id);
            {
                if (actorDetail == null) return View("INga resultat");
                return View(actorDetail);
            }
        }

        public async Task<IActionResult> Edit(int id)
        {
            var actorDetails = await _context.GetByIdAsync(id);
            if (actorDetails == null) return View("Inga resultat");
            return View(actorDetails);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id,[Bind("Name,ImgURL,Desc")] Actor actor)
        {
            if (!ModelState.IsValid)
            {

                return View(actor);
            }
            await _context.UpdateAsync(id, actor);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var actorDetails = await _context.GetByIdAsync(id);
            if (actorDetails == null) return View("Index");
            return View(actorDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actorDetails = await _context.GetByIdAsync(id);
            if (actorDetails == null) return View("Index");

            await _context.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
