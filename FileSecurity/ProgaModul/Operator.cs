using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgaModul
{
    class Operator
    {
        public static List<Operator> Operators = new List<Operator>();
        public string login;
        public string password;
        public Operator(string login, string password)
        {
            this.login = login;
            this.password = password;
        }
        public static void AddOperator(string login, string password)
        {
            Operators.Add(new Operator(login, password));
        }
        public static void DeleteOperator(string login)
        {
            for (int i = 0; i < Operators.Count; i++)
            {
                if (Operators[i].login == login)
                {
                    Operators.Remove(Operators[i]);
                    break;
                }
            }
        }
    }
}
