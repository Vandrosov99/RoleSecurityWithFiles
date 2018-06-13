using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ProgaModul
{
    static class MainProg
    {
        static string currentUser;
        static string login;
        static string password;
        public static void Start()
        {
            Admin mainAdmin = new Admin("a0", "a0p");
            Admin.Admins.Add(mainAdmin);
            LogIn();
        }
        static void LogIn()
        {
            Console.WriteLine("Hello, pls enter your login and password to continue:");
            Console.WriteLine("Login: ");
            login = Console.ReadLine();
            Console.WriteLine("Password: ");
            password = Console.ReadLine();
            for(int i = 0; i < Operator.Operators.Count; i++)
            {
                if(login == Operator.Operators[i].login && password == Operator.Operators[i].password)
                {
                    currentUser = "Operator";
                    Commands();
                }
            }
            for (int i = 0; i < Manager.Managers.Count; i++)
            {
                if (login == Manager.Managers[i].login && password == Manager.Managers[i].password)
                {
                    currentUser = "Manager";
                    Commands();
                }
            }
            for (int i = 0; i < Admin.Admins.Count; i++)
            {
                if (login == Admin.Admins[i].login && password == Admin.Admins[i].password)
                {
                    currentUser = "Admin";
                    Commands();
                }
            }
            Console.WriteLine("No such logins have been found. Try again");
            LogIn();
        }
        static void Commands()
        {
            Console.WriteLine("Hello " + currentUser);
            Console.WriteLine("Enter a command: ");
            string command = Console.ReadLine();
            switch(currentUser)
            {
                case "Operator":
                    switch(command)
                    {
                        case "adddoc":
                            Console.WriteLine("Enter full name of doc you want to add:");
                            string doc = Console.ReadLine();
                            txtFile file = new txtFile(doc);
                            Commands();
                            break;
                        case "readdoc":
                            Console.WriteLine("Enter full name of doc you want to read:");
                            string docToRead = Console.ReadLine();
                            for(int i = 0; i < txtFile.FileBase.Count+1; i++)
                            {
                                if(docToRead == txtFile.FileBase[i].GetName())
                                {
                                    txtFile.FileBase[i].Display();
                                    Commands();
                                }
                                Console.WriteLine("No such file has been found");
                                Commands();
                            }
                            break;
                        case "exit":
                            LogIn();
                            break;
                        default:
                            Console.WriteLine("No such command exists");
                            Commands();
                            break;
                    }
                    break;
                case "Manager":
                    switch (command)
                    {
                        case "adddoc":
                            Console.WriteLine("Enter full name of doc you want to add:");
                            string doc = Console.ReadLine();
                            txtFile file = new txtFile(doc);
                            Commands();
                            break;
                        case "readdoc":
                            Console.WriteLine("Enter full name of doc you want to read:");
                            string docToRead = Console.ReadLine();
                            for (int i = 0; i < txtFile.FileBase.Count+1; i++)
                            {
                                if (docToRead == txtFile.FileBase[i].GetName())
                                {
                                    txtFile.FileBase[i].Display();
                                    Commands();
                                }
                                Console.WriteLine("No such file has been found");
                                Commands();
                            }
                            break;
                        case "deletedoc":
                            Console.WriteLine("Enter full name of doc you want to delete:");
                            string docToDelete = Console.ReadLine();
                            for (int i = 0; i < txtFile.FileBase.Count; i++)
                            {
                                if (docToDelete == txtFile.FileBase[i].GetName())
                                {
                                    txtFile.FileBase.Remove(txtFile.FileBase[i]);
                                    Commands();
                                }
                                Console.WriteLine("No such file has been found");
                                Commands();
                            }
                            break;
                        case "exit":
                            LogIn();
                            break;
                        default:
                            Console.WriteLine("No such command exists");
                            Commands();
                            break;
                    }
                    break;
                case "Admin":
                    switch (command)
                    {
                        case "addmember":
                            Admin.AddMember();
                            Commands();
                            break;
                        case "deletemember":
                            Admin.DeleteMember();
                            Commands();
                            break;
                        case "exit":
                            LogIn();
                            break;
                        default:
                            Console.WriteLine("No such command exists");
                            Commands();
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("No such user exists");
                    LogIn();
                    break;
            }
        }
    }
}
