using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cybrary.Models;
using Cybrary.Data;
using System.Diagnostics.Metrics;

namespace Cybrary.Pages.Books
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public EditModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                Book = new Book();
            }
            else
            {
                Book = await _context.Book.FindAsync(id);

                if (Book == null)
                {
                    return NotFound();
                }
            }
            return Page();
        }


        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (id == null)
            {
                _context.Book.Add(Book);
            }
            else
            {
                Book existingBook = await _context.Book.FindAsync(id);

                if (existingBook == null)
                {
                    return NotFound();
                }

                existingBook.Title = Book.Title;
                existingBook.Author = Book.Author;
                existingBook.Publisher = Book.Publisher;
                existingBook.Year = Book.Year;
                existingBook.ISBN = Book.ISBN;
                existingBook.Resume = Book.Resume;
                existingBook.Price = Book.Price;

                _context.Book.Update(existingBook);
            }

            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

    }
}
