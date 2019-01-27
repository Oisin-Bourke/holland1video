using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesHolland.Models;

namespace RazorPagesHolland.Pages.Hollands
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesHolland.Models.RazorPagesHollandContext _context;

        public DetailsModel(RazorPagesHolland.Models.RazorPagesHollandContext context)
        {
            _context = context;
        }

        public Holland Holland { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Holland = await _context.Holland.FirstOrDefaultAsync(m => m.ID == id);

            if (Holland == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
