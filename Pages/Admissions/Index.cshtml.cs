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
    public class IndexModel : PageModel
    {
        private readonly ArmySchoolEntityFramework.Data.ArmySchoolEntityFrameworkContext _context;

        public IndexModel(ArmySchoolEntityFramework.Data.ArmySchoolEntityFrameworkContext context)
        {
            _context = context;
        }

        public IList<Admission> Admission { get;set; }

        public async Task OnGetAsync()
        {
            Admission = await _context.Admission
                .Include(a => a.Student)
                .Include(a => a.Subject).ToListAsync();
        }
    }
}
