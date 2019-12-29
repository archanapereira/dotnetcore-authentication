using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

using MyBookApplication.Data;
using MyBookApplication.Models;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyBookApplication.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly BookDbContext _context;

        public IndexModel(BookDbContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get; set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Books.ToListAsync();
        }
    }
}