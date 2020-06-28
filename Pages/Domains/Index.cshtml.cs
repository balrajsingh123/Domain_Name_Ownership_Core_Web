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
    //Gets all domain infmration
    public class IndexModel : PageModel
    {
        private readonly Domain_Name_Ownership_Core_Web.Models.Domain_Name_Ownership_Context _context;

        public IndexModel(Domain_Name_Ownership_Core_Web.Models.Domain_Name_Ownership_Context context)
        {
            _context = context;
        }

        public IList<Domain> Domain { get;set; }

        public async Task OnGetAsync()
        {
            Domain = await _context.Domain
                .Include(d => d.DomainHost).ToListAsync();
        }
    }
}
