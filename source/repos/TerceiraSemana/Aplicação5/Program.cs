using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicação5
{
    internal class Program
    {
            static void Main(string[] args)
        {
            //Declarar vaiáveis
            decimal jan, fev, mar, media;
            //Entrada de dados
            jan = 1000;
            fev = 2000;
            mar = 3000;
            //Processamento de dados
            media = (jan + fev + mar) / 3;
            //Saída de dados
            Console.WriteLine(media);
            //Parar a tela
            Console.ReadLine();
            
        }
    }
}
