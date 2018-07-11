using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneratorName;

namespace EgovMedical.LIB.Interfaces
{
    interface IPatient
    {
        string FullName { get; set; }
        int Age();
        Gender Sex { get; set; }
        DateTime DOB { get; set; }
        string IIN { get; set; }
    }
}
