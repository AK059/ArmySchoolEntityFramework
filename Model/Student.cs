using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArmySchoolEntityFramework.Model
{
    //Add Student class here
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public int Age { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
        public DateTime AdmissionDate { get; set; }

        //Add ICollection
        public ICollection<Admission> Admission { get; set; }
    }
}
