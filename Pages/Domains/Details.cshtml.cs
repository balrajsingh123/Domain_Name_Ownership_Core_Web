using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Domain_Name_Ownership_Core_Web.BusinessLayer;
using Domain_Name_Ownership_Core_Web.Models;

namespace Domain_Name_Ownership_Core_Web.Pages.Domains
{
    //Gets the domain information from DB
    public class DetailsModel : PageModel
    {
        private readonly Domain_Name_Ownership_Core_Web.Models.Domain_Name_Ownership_Context _context;

        public DetailsModel(Domain_Name_Ownership_Core_Web.Models.Domain_Name_Ownership_Context context)
        {
            _context = context;
        }

        public Domain Domain { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Domain = await _context.Domain
                .Include(d => d.DomainHost).FirstOrDefaultAsync(m => m.Id == id);

            if (Domain == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
