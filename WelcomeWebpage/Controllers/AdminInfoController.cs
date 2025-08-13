using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WelcomeWebpage.Models;







namespace WelcomeWebpage.Controllers
{
    public class AdminInfoController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AdminInfoController(ApplicationDbContext context) => _context = context;

        public async Task<IActionResult> Index()
    => View(await _context.AdminInfos.AsNoTracking().ToListAsync());


        [HttpGet] public IActionResult Create() => View();

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AdminInfo admin)
        {
            if (!ModelState.IsValid) return View(admin);
            _context.AdminInfos.Add(admin);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var admin = await _context.AdminInfos.FindAsync(id);
            if (admin == null) return NotFound();
            return View(admin);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, AdminInfo admin)
        {
            if (id != admin.Id) return BadRequest();
            if (!ModelState.IsValid) return View(admin);
            _context.Update(admin);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var admin = await _context.AdminInfos.FindAsync(id);
            if (admin == null) return NotFound();
            return View(admin);
        }

        [HttpPost, ActionName("Delete"), ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var admin = await _context.AdminInfos.FindAsync(id);
            if (admin == null) return NotFound();
            _context.AdminInfos.Remove(admin);   
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}

