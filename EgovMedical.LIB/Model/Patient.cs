using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgovMedical.LIB.Interfaces;
using GeneratorName;


namespace EgovMedical.LIB.Model
{
   public  class Patient :IPatient
    {
        public string FullName { get; set; }
        public string IIN { get; set; }
        public Gender Sex { get; set; }
        public DateTime DOB { get; set; }
        public int Age() { return DateTime.Now.Year - DOB.Year; }


    }
}
