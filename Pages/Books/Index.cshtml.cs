using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cybrary.Data;
using Cybrary.Models;
using System.Linq;


namespace Cybrary.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Book> Books{ get; set; }

        public async Task OnGetAsync(string author)
        {
            Books = await _context.Book
            .Where(d => d.Author == author)
            .ToListAsync();

            if (author == "All" || string.IsNullOrEmpty(author))
            {
                Books = await _context.Book.ToListAsync();
            }
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Book existingBook = await _context.Book.FindAsync(id);

            if (existingBook == null)
            {
                return NotFound();
            }

            _context.Book.Remove(existingBook);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
