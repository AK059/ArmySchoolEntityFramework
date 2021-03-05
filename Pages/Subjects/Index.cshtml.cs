using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ArmySchoolEntityFramework.Data;
using ArmySchoolEntityFramework.Model;

namespace ArmySchoolEntityFramework.Pages.Subjects
{
    public class IndexModel : PageModel
    {
        private readonly ArmySchoolEntityFramework.Data.ArmySchoolEntityFrameworkContext _context;

        public IndexModel(ArmySchoolEntityFramework.Data.ArmySchoolEntityFrameworkContext context)
        {
            _context = context;
        }

        public IList<Subject> Subject { get;set; }

        public async Task OnGetAsync()
        {
            Subject = await _context.Subject.ToListAsync();
        }
    }
}
