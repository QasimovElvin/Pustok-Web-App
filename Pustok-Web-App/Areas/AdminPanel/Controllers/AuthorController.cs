using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pustok_Web_App.DAL;

namespace Pustok_Web_App.Areas.AdminPanel.Controllers
{
        [Area("AdminPanel")]
    public class AuthorController : Controller
    {

        private readonly AppDbContext _context;

        public AuthorController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.AuthorS.ToListAsync());
        }
    }
}
