using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArmySchoolEntityFramework.Model
{
    //Adding enum Grade here
    public enum Grade
    {
        A, B, C, D, F
    }
    //Adding Admission class here

    public class Admission
    {
        public int AdmissionID { get; set; }
        public int SubjectID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }

        public Subject Subject{ get; set; }
        public Student Student { get; set; }
    }
}
