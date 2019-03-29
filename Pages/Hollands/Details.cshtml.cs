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

        public static string rovCoordinates;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //make holland instance by id accessible in view and include the its surveys  
            Holland = await _context.Holland
                                    .Include(s => s.Surveys)
                                    .AsNoTracking()
                                    .FirstOrDefaultAsync(m => m.ID == id);


           // Holland = await _context.Holland.FirstOrDefaultAsync(m => m.ID == id);

            if (Holland == null)
            {
                return NotFound();
            }

            //generating the rovCoordinates:


            rovCoordinates = "[";

            foreach (var item in Holland.Surveys)
            {
                rovCoordinates += "{";
                rovCoordinates += string.Format("'lat': '{0}',", item.Latitude);
                rovCoordinates += string.Format("'lng': '{0}',", item.Longitude);
                rovCoordinates += "},";
            }

            rovCoordinates += "]";


            
            

            return Page();
        }
    }
}
