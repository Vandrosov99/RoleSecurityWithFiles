using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgaModul
{
    class Manager
    {
        public static List<Manager> Managers = new List<Manager>();
        public string login;
        public string password;
        public Manager(string login, string password)
        {
            this.login = login;
            this.password = password;
        }
        public static void AddManager(string login, string password)
        {
            Managers.Add(new Manager(login, password));
        }
        public static void DeleteManager(string login)
        {
            for(int i = 0; i < Managers.Count; i++)
            {
                if (Managers[i].login == login)
                {
                    Managers.Remove(Managers[i]);
                    break;
                }
            }
        } 
    
    }
}
