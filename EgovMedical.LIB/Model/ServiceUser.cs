using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace EgovMedical.LIB.Model
{
    public class ServiceUser
    {
        public static bool Registration(User user)
        {
            try
            {
                using (var db = new LiteDatabase(@"EgovMedDB.db"))
                {
                    LiteCollection<User> users = db.GetCollection<User>("User");
                    users.Insert(user);
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.Gray;
                return false;
            }
        }

        public static void GetAllUser()
        {
            using (var db = new LiteDatabase(@"EgovMedDB.db"))
            {
                LiteCollection<User> users = db.GetCollection<User>("User");
                foreach (var item in users.FindAll())
                {
                    Console.WriteLine("ФИО:{0}\t дата регистрации: {1}", item.FullName, item.CreateDate);
                }
            }
        }
    }
}
