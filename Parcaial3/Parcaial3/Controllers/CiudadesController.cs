using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Parcial3.Data;
using Parcial3.Data.Parcial3.Data;
using Parcial3.Models;

namespace Parcial3.Controllers
{
    public class CiudadesController : Controller
    {

        private readonly ApplicationDbContext _context;

        public CiudadesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ActionResult> Index()
        {
     
            var ciudades = await _context.Ciudades.ToListAsync();

      
            return View(ciudades);
        }


        public ActionResult Create()
        {
            return View();
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind("Id,Nombre")] Ciudades ciudad)
        {
            if (ModelState.IsValid)
            {
                
                _context.Ciudades.Add(ciudad);
                await _context.SaveChangesAsync();

               
                return RedirectToAction(nameof(Index));
            }
            return View(ciudad);
        }
    }
}
