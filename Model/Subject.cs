using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArmySchoolEntityFramework.Model
{
    //Add Subject Class 
    public class Subject
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SubjectID { get; set; }
        public string Subjects { get; set; }
        public int Credits { get; set; }
        //Add Relation  

        public ICollection<Admission> Admissions{ get; set; }
    }
}
