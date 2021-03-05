using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ArmySchoolEntityFramework.Data;
using ArmySchoolEntityFramework.Model;

namespace ArmySchoolEntityFramework.Pages.Admissions
{
    public class CreateModel : PageModel
    {
        private readonly ArmySchoolEntityFramework.Data.ArmySchoolEntityFrameworkContext _context;

        public CreateModel(ArmySchoolEntityFramework.Data.ArmySchoolEntityFrameworkContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["StudentID"] = new SelectList(_context.Student, "ID", "ID");
        ViewData["SubjectID"] = new SelectList(_context.Subject, "SubjectID", "SubjectID");
            return Page();
        }

        [BindProperty]
        public Admission Admission { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Admission.Add(Admission);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
