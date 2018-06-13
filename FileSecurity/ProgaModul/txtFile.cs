using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgaModul
{
    class txtFile
    {
        public static List<txtFile> FileBase = new List<txtFile>();
        private string name;
        public txtFile(string name)
        {
            this.name = name;
            FileBase.Add(this);
        }
        public string GetName()
        {
            return name;
        }
        public void Display()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\User\source\repos\ProgaModul\TestFolder\" + this.name + ".txt");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
