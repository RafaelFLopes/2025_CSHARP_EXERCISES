//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//using csharp_exercicios.calculadoraUtilizandoMetodosEmUmArquivoDiferente;
//class Calculadora
//{
//    static void Main(string[] args)
//    { 
//        Console.WriteLine("Calculadora Simples utilizando métodos em um arquivo diferente");

//        int opcao;

//        do
//        {
//            Console.WriteLine("Selecione a operação");
//            Console.WriteLine("1 = somar");
//            Console.WriteLine("2 = subtrair");
//            Console.WriteLine("3 = multiplicar");
//            Console.WriteLine("4 = dividir");
//            Console.WriteLine("99 = sair");

//            opcao = int.Parse(Console.ReadLine());

//            if (opcao != 99) {

//                Console.WriteLine("Digite o primeiro número");

//                int primeiroNumero = int.Parse(Console.ReadLine());

//                Console.WriteLine("Digite o segundo número");

//                int segundoNumero = int.Parse(Console.ReadLine());

//                switch (opcao)
//                {
//                    case 1:
//                        int resultadoSoma = operacoes.Somar(primeiroNumero, segundoNumero);
//                        Console.WriteLine("O resultado da soma é: " + resultadoSoma);
//                        break;

//                    case 2:
//                        int resultadoSubtracao = operacoes.Subtrair(primeiroNumero, segundoNumero);
//                        Console.WriteLine("O resultado da subtracao é: " + resultadoSubtracao);
//                        break;
//                    case 3:
//                        int resultadoMultiplicacao = operacoes.Multiplicar(primeiroNumero, segundoNumero);
//                        Console.WriteLine("O resultado da multiplicacao é: " + resultadoMultiplicacao);
//                        break;
//                    case 4:
//                        int resultadoDivisao = operacoes.Dividir(primeiroNumero, segundoNumero);
//                        Console.WriteLine("O resultado da divisao é: " + resultadoDivisao);
//                        break;
//                }
//            }
//            else
//            {
//                Console.WriteLine("fechando");
//            }

//        } while (opcao != 99);
//    }
//}