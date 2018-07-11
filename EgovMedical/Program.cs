using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgovMedical.LIB.Model;
 using GeneratorName;

namespace EgovMedical
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceUser.GetAllUser();
            PrintMenu();
            int answer = Int32.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    {

                    }
                    break;
                case 2:
                    {
                        ServiceUser.Registration(GetUserInfoForRegistration());
                    }
                    break;
                default:
                    break;
            }
        }

        static public void PrintMenu()
        {
            Console.WriteLine("1.Войти\n2Регистрация");
        }
        static public User GetUserInfoForRegistration()
        {
            User user = new User();
            Console.Write("{0, -40} ", "Введите ФИО: ");
            user.FullName = Console.ReadLine();
            Console.Write("{0, -40} ", "Введите ИИН: ");
            user.IIN = Console.ReadLine();
            Console.Write("{0, -40} ", "Введите дату рождения: ");
            user.DOB =DateTime.Parse( Console.ReadLine());
            Console.Write("{0, -40} ", "Введите пол(0 - жен, 1 - муж): ");
           user.Sex = (Gender)Int32.Parse(Console.ReadLine());
            Console.Write("{0, -40} ", "Введите логин: ");
            user.login = Console.ReadLine();
            Console.Write("{0, -40} ", "Введите пароль: ");
            user.password = Console.ReadLine();

            user.CreateDate = DateTime.Now;
            user.IsBlocked = false;
            return user;
        }

    }
}
