using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu peso: ");
            int peso = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua altura: ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine("O IMC é de : " + imc);

            if (imc < 16.9)
            {
                Console.WriteLine("Muito abaixo do peso.");
            } else if (imc <= 18.4)
            {
                Console.WriteLine("Abaixo do peso.");
            } else if(imc <= 24.9)
            {
                Console.WriteLine("Peso normal.");
            } else if(imc <= 29.9)
            {
                Console.WriteLine("Acima do peso.");
            } else if(imc <= 34.9)
            {
                Console.WriteLine("Obesidade grau I.");
            } else if(imc <= 40)
            {
                Console.WriteLine("Obesidade grau II.");
            } else if(imc > 40)
            {
                Console.WriteLine("Obesidade grau III.");
            }

            Console.ReadKey();

            // e &&, ou ||, não !
        }
    }
}
