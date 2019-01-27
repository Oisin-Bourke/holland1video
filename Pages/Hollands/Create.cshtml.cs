using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesHolland.Models;

namespace RazorPagesHolland.Pages.Hollands
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesHolland.Models.RazorPagesHollandContext _context;

        public CreateModel(RazorPagesHolland.Models.RazorPagesHollandContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Holland Holland { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Holland.Add(Holland);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}