using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{
    internal class Program
    {
        double i = 0;
        static void Main(string[] args)
        {

            {
                Console.SetCursorPosition(0, 0);
                Console.Write("Insert Celcius number ");
                string txt = Console.ReadLine();
                double i = Int32.Parse(txt);
                Console.WriteLine(i * 1.8 + 32);
                Console.WriteLine("From Celcius to Farhrenheit");
                Console.SetCursorPosition(0, 4);
                Console.WriteLine(i * 0.8);
                Console.WriteLine("From Celcius to Reamur");
            }// note start without debugging works better then the debugging version.


           










        }
    }
}
