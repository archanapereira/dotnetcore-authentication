using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

using MyBookApplication.Data;
using MyBookApplication.Models;

using System.Threading.Tasks;

namespace MyBookApplication.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly BookDbContext _context;

        public DetailsModel(BookDbContext context)
        {
            _context = context;
        }

        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Books.FirstOrDefaultAsync(m => m.Id == id);

            if (Book == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}