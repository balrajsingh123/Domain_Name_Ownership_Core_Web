using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Domain_Name_Ownership_Core_Web.BusinessLayer;
using Domain_Name_Ownership_Core_Web.Models;

namespace Domain_Name_Ownership_Core_Web.Pages.Owners
{
    //Create an owner
    public class CreateModel : PageModel
    {
        private readonly Domain_Name_Ownership_Core_Web.Models.Domain_Name_Ownership_Context _context;

        public CreateModel(Domain_Name_Ownership_Core_Web.Models.Domain_Name_Ownership_Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Owner Owner { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Owner.Add(Owner);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
