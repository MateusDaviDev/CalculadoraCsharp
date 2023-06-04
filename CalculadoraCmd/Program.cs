using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CalculadoraCmd
{
    class Program
    {
        enum Menu
        {
            Soma=1, Subtracao = 2, Divisao = 3, Multiplicacao = 4, Potencia = 5, Raiz = 6, Sair = 7
        }
        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while (!escolheuSair) 
            {
                Console.WriteLine("Seja bem vindo a calculadora, selecione uma das opções");
                Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potência\n6-Raiz\n7-Sair");
                Menu opcao = (Menu)int.Parse(Console.ReadLine());
                Console.WriteLine(opcao);
                Console.Clear();

                Operacoes minhasOperacoes = new Operacoes();

                switch (opcao)
                {
                    case Menu.Sair:
                        escolheuSair = true;
                        break;

                    case Menu.Soma:
                        minhasOperacoes.Soma();
                        break;

                    case Menu.Subtracao:
                        minhasOperacoes.Subtracao();
                        break;
                    case Menu.Divisao:
                        minhasOperacoes.Divisao();
                        break;
                    case Menu.Multiplicacao:
                        minhasOperacoes.Multiplicacao();
                        break;
                    case Menu.Potencia:
                        minhasOperacoes.Potencia();
                        break;
                    case Menu.Raiz:
                        minhasOperacoes.RaizQuadrada();
                        break;
                }






            } 

        }
        
    }
}
