using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LSPSolutionApp.Model;

namespace LSPSolutionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruit f = new Apple();
            Console.WriteLine("Color of Apple is : " + f.GetColor());
            f = new Orange();
            Console.WriteLine("Color of Orange is : " + f.GetColor());
            Console.ReadLine();
        }
    }
}
