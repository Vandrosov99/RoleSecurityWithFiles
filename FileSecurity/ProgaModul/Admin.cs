using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgaModul
{
    class Admin
    {
        public static List<Admin> Admins = new List<Admin>();
        public string login;
        public string password;
        public Admin(string login, string password)
        {
            this.login = login;
            this.password = password;
        }
        public static void AddAdmin(string login, string password)
        {
            Admins.Add(new Admin(login, password));
        }
        public static void DeleteAdmin(string login)
        {
            for (int i = 0; i < Admins.Count; i++)
            {
                if (Admins[i].login == login)
                {
                    Admins.Remove(Admins[i]);
                    break;
                }
            }
        }
        public static void AddMember()
        {
            Console.WriteLine("Enter new user's data");
            Console.WriteLine("Enter his login");
            string newLogin = Console.ReadLine(); ;
            Console.WriteLine("Enter his password");
            string newPassword = Console.ReadLine(); ;
            Console.WriteLine("Which member you want to add ? Manager Operator ar Admin ?");
            string memberType = Console.ReadLine();
            switch(memberType)
            {
                case "Manager":
                    Manager.AddManager(newLogin, newPassword);
                    break;
                case "Admin":
                    AddAdmin(newLogin, newPassword);
                    break;
                case "Operator":
                    Operator.AddOperator(newLogin, newPassword);
                    break;
                default:
                    Console.WriteLine("No such a role was found");
                    break;
            }
        }
        public static void DeleteMember()
        {
            Console.WriteLine("Enter user's login u want to delete");
            Console.WriteLine("Enter his login");
            string newLogin = Console.ReadLine();
            Console.WriteLine("Which member you want to delete ? Manager Operator ar Admin ?");
            string memberType = Console.ReadLine();
            switch (memberType)
            {
                case "Manager":
                    Manager.DeleteManager(newLogin);
                    break;
                case "Admin":
                    DeleteAdmin(newLogin);
                    break;
                case "Operator":
                    Operator.DeleteOperator(newLogin);
                    break;
                default:
                    Console.WriteLine("No such a role was found");
                    break;
            }
        }
    }
}
