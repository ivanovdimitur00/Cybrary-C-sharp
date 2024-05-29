using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
//using Cybrary.Models; // Assuming you have a model class to store the contact form data

namespace Cybrary.Pages.Books
{
    public class ContactModel : PageModel
    {

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            // Display a success message using JavaScript alert
            TempData["SuccessMessage"] = "Your message has been sent successfully.";

            return Page();
        }
    }
}
