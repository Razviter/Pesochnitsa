using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS50__Csharp_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Фамилию Имя Отчество");
            string name = Console.ReadLine();
            Console.WriteLine(char.ToUpper(name[0]));
            for (int i = 0, n = lentgh(name); i < n; i++)
        }
    }
}
