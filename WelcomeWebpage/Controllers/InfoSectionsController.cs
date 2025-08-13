using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WelcomeWebpage.Models;



namespace WelcomeWebpage.Controllers
{
    public class InfoSectionsController : Controller
    {
        private readonly ApplicationDbContext _db;
        public InfoSectionsController(ApplicationDbContext db) => _db = db;

        // GET: /Sections
        public async Task<IActionResult> Index() =>
            View(await _db.InfoSections.AsNoTracking().OrderBy(s => s.SortOrder).ToListAsync());

        // GET: /Sections/Edit?slug=about-the-house
        [HttpGet]
        public async Task<IActionResult> Edit(string slug)
        {
            if (string.IsNullOrWhiteSpace(slug)) return BadRequest();
            var section = await _db.InfoSections.FirstOrDefaultAsync(s => s.Slug == slug);
            if (section == null) return NotFound();
            return View(section);
        }

        // POST: /Sections/Edit
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string slug, InfoSection model)
        {
            if (!ModelState.IsValid) return View(model);

            var section = await _db.InfoSections.FirstOrDefaultAsync(s => s.Slug == slug);
            if (section == null) return NotFound();

            section.Title = model.Title;
            section.Content = model.Content;
            section.SortOrder = model.SortOrder;
            section.IsVisible = model.IsVisible;

            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
