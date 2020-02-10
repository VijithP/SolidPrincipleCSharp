using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_IMP
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Each implementation on each class.

            Console.WriteLine("Single Reponsibility Principle");
            Console.WriteLine("_____________________________");

            SingleReposibility sr = new SingleReposibility();

            Console.WriteLine();
            Console.WriteLine("Open Closed Principle");
            Console.WriteLine("_____________________________");
            OpenClosed op = new OpenClosed();

            Console.ReadKey();


        }
    }
}
