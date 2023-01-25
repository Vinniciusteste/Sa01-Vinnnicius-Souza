using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicação2
{
    internal class Program
    {
        private static int anotual;

        static void Main(string[] args)
        {


            int anoatual, subtração = 0;

            Console.WriteLine("Digite o ano atual: ");
            anoatual = int.Parse(Console.ReadLine());

            subtração = anotual - 1968;

            Console.WriteLine("O valor da subtração é:  " + subtração);
            Console.ReadLine();
       
        }
    }
}
