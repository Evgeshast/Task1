using System;
using System.Linq;
using StringLib;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringClass stringClass = new StringClass();
            Console.WriteLine(stringClass.GetWelcomeString(args[0]));
        }
    }
}
