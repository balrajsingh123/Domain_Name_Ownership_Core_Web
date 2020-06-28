using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain_Name_Ownership_Core_Web.BusinessLayer;
using Domain_Name_Ownership_Core_Web.Models;

namespace Domain_Name_Ownership_Core_Web.Pages.Ownerships
{
    //Removes the ownership
    public class EditModel : PageModel
    {
        private readonly Domain_Name_Ownership_Core_Web.Models.Domain_Name_Ownership_Context _context;

        public EditModel(Domain_Name_Ownership_Core_Web.Models.Domain_Name_Ownership_Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Ownership Ownership { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Ownership = await _context.Ownership
                .Include(o => o.Domain)
                .Include(o => o.Owner).FirstOrDefaultAsync(m => m.Id == id);

            if (Ownership == null)
            {
                return NotFound();
            }
           ViewData["DomainId"] = new SelectList(_context.Domain, "Id", "DomainName");
           ViewData["OwnerId"] = new SelectList(_context.Owner, "Id", "OwnerName");
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Ownership).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OwnershipExists(Ownership.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool OwnershipExists(int id)
        {
            return _context.Ownership.Any(e => e.Id == id);
        }
    }
}
