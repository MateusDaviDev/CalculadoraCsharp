using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCmd
{
    class Operacoes
    {
       public void Soma()
        {
            Console.WriteLine("Soma de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero:");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo numero:");
            float b = float.Parse(Console.ReadLine());
            float resultado = a + b;
            Console.WriteLine("O resultado da soma é: " + resultado);
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();


        }

       public void Subtracao()
        {
            Console.WriteLine("Subtracao de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero:");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo numero:");
            float b = float.Parse(Console.ReadLine());
            float resultado = a - b;
            Console.WriteLine("O resultado da Subtracao é: " + resultado);
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();

        }

        public void Divisao()
        {
            Console.WriteLine("Divisao de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero:");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo numero:");
            float b = float.Parse(Console.ReadLine());
            float resultado = a / b;
            Console.WriteLine("O resultado da Divisao é: " + resultado);
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();

        }

        public void Multiplicacao()
        {
            Console.WriteLine("Multiplicacao de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero:");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo numero:");
            float b = float.Parse(Console.ReadLine());
            float resultado = a * b;
            Console.WriteLine("O resultado da Divisao é: " + resultado);
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();

        }

        public void Potencia()
        {
            Console.WriteLine("Potencia de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero:");
            float baseNum = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo numero:");
            float expo = float.Parse(Console.ReadLine());
            double resultado = Math.Pow(baseNum, expo);
            Console.WriteLine("O resultado da Divisao é: " + resultado);
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();

        }

        public void RaizQuadrada()
        {
            Console.WriteLine("Raiz de um  numeros: ");
            float raizNum = float.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(raizNum);
            Console.WriteLine("O resultado da Raiz de " + raizNum + " é: " + resultado.ToString("F"));
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();

        }
    }
}
