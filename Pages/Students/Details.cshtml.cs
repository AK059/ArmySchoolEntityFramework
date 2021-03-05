using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ArmySchoolEntityFramework.Data;
using ArmySchoolEntityFramework.Model;

namespace ArmySchoolEntityFramework.Pages.Students
{
    public class DetailsModel : PageModel
    {
        private readonly ArmySchoolEntityFramework.Data.ArmySchoolEntityFrameworkContext _context;

        public DetailsModel(ArmySchoolEntityFramework.Data.ArmySchoolEntityFrameworkContext context)
        {
            _context = context;
        }

        public Student Student { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Student = await _context.Student.FirstOrDefaultAsync(m => m.ID == id);

            if (Student == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
