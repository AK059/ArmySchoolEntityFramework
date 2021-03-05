using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ArmySchoolEntityFramework.Data;
using ArmySchoolEntityFramework.Model;

namespace ArmySchoolEntityFramework.Pages.Admissions
{
    public class DeleteModel : PageModel
    {
        private readonly ArmySchoolEntityFramework.Data.ArmySchoolEntityFrameworkContext _context;

        public DeleteModel(ArmySchoolEntityFramework.Data.ArmySchoolEntityFrameworkContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Admission Admission { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Admission = await _context.Admission
                .Include(a => a.Student)
                .Include(a => a.Subject).FirstOrDefaultAsync(m => m.AdmissionID == id);

            if (Admission == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Admission = await _context.Admission.FindAsync(id);

            if (Admission != null)
            {
                _context.Admission.Remove(Admission);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
