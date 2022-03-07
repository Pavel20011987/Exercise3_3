using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку для ее перевода в обратном порядке: ");
            string str = Console.ReadLine();

            if (str != null)
                Console.WriteLine(new string(str.Reverse().ToArray()));
        }
    }
}
