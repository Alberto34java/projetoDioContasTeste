using System.Linq;
using System.Threading.Tasks;
using data;
using Microsoft.AspNetCore.Mvc;

namespace Controllers
{
    [Controller]
    [Route("/[controller]")]
    public class BancoSAController : Controller
    {
        private readonly Context _context;
        public BancoSAController(Context context)
        {
            _context = context;
        }

        public async Task<ActionResult> Index()
        {
            return View(_context.BancoSAs.ToList() );
        }
    }
}