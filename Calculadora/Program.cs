using ProjetoDllCalculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTesteCalculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora c1 = new Calculadora();
            double result = c1.Somar(3.5, 4.5);
            Console.WriteLine("Soma={0}", result);
            Console.ReadLine();
        }
    }
}
