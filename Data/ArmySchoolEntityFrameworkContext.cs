using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ArmySchoolEntityFramework.Model;

namespace ArmySchoolEntityFramework.Data
{
    public class ArmySchoolEntityFrameworkContext : DbContext
    {
        public ArmySchoolEntityFrameworkContext (DbContextOptions<ArmySchoolEntityFrameworkContext> options)
            : base(options)
        {
        }

        public DbSet<ArmySchoolEntityFramework.Model.Admission> Admission { get; set; }

        public DbSet<ArmySchoolEntityFramework.Model.Student> Student { get; set; }

        public DbSet<ArmySchoolEntityFramework.Model.Subject> Subject { get; set; }
    }
}
