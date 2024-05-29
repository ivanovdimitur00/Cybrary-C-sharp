using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Cybrary.Data;
using Cybrary.Models;

namespace Cybrary.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public string Author { get; set; }

        public List<SelectListItem> Authors { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            var books = await _context.Book.ToListAsync();

            Authors = books
                .Select(d => new SelectListItem(d.Author, d.Author))
                .GroupBy(c => c.Value)
                .Select(g => g.First())
                .ToList();
        }
    }
}