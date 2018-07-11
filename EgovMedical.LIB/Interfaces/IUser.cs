using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneratorName;

namespace EgovMedical.LIB.Interfaces
{
    interface IUser
    {
        int UserId { get; set; }
        string login { get; set; }
        string password { get; set; }
        int role { get; set; }
        DateTime CreateDate { get; set; }
        string CreateBy { get; set; }
        bool IsBlocked { get; set; }
        void BlockUser(bool status);
    }
}