using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IKalkulator
    {
        int Mnozenie(int a, int b);
    }
    interface IPotegowanie
    {
        int Potegowanie(int a);
    }

    class Adaptee : IKalkulator,IPotegowanie
    {
        public int Mnozenie(int a, int b)
        {
            return a * b;
        }
        public int Potegowanie(int a)
        {
            return Mnozenie(a, a);
        }
    }
    class Kalkulator : IKalkulator
    {
        public int Mnozenie(int a, int b)
        {
            return a * b;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Adaptee adaptee = new Adaptee();
            Console.WriteLine(adaptee.Mnozenie(2, 3));
            Console.WriteLine(adaptee.Potegowanie(5));
        }
    }
}
