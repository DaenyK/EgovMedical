using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgovMedical.LIB.Interfaces;
using GeneratorName;

namespace EgovMedical.LIB.Model
{
    public class User : IUser, IPatient
    {
        public string CreateBy { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime DOB { get; set; }

        public string FullName { get; set; }
        public string IIN { get; set; }
        public bool IsBlocked { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public int role { get; set; }
        public Gender Sex { get; set; }
        public int UserId { get; set; }
        public int Age() { return DateTime.Now.Year - DOB.Year; }
        public void BlockUser(bool status)
        {
            throw new NotImplementedException();
        }
    }
}
