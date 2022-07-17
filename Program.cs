using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload
{
    internal class Program
    {
        public void Main(string[] args)
        {
            Islemler();
            Islemler("Soner", "Arı");
            Islemler(5 , 9);

        }
        public void Islemler(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Islemler(string a , string b)
        {
            Console.WriteLine(a + " " + b);
        }
        public void Islemler()
        {
            Console.WriteLine("Hello, World!");
        }

    }
}
