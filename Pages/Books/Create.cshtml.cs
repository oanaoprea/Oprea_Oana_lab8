using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Oprea_Oana_lab8.Data;
using Oprea_Oana_lab8.Models;

namespace Oprea_Oana_lab8.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly Oprea_Oana_lab8.Data.Oprea_Oana_lab8Context _context;

        public CreateModel(Oprea_Oana_lab8.Data.Oprea_Oana_lab8Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Book.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
