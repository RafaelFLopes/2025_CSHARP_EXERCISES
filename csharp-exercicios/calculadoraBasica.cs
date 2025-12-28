//using System;

//class CalculadoraBasica
//{
//    static void Main(string[] args)
//    {
//        int opcao;

//        do
//        {
//            Console.WriteLine("Selecione a operação desejada:");
//            Console.WriteLine("1 - Adição");
//            Console.WriteLine("2 - Subtração");
//            Console.WriteLine("3 - Multiplicação");
//            Console.WriteLine("4 - Divisão");
//            Console.WriteLine("99 - Sair");

//            opcao = int.Parse(Console.ReadLine());

//            Console.Write("Digite o primeiro valor: ");
//            int valor1 = int.Parse(Console.ReadLine());

//            Console.Write("Digite o segundo valor: ");
//            int valor2 = int.Parse(Console.ReadLine());

//            int resultado;

//            switch (opcao)
//            {
//                case 1:
//                    resultado = valor1 + valor2;
//                    Console.WriteLine("O resultado da adição é igual a: " + resultado);
//                    break;
//                case 2:
//                    resultado = valor1 - valor2;
//                    Console.WriteLine("O resultado da subtração é igual a: " + resultado);
//                    break;
//                case 3:
//                    resultado = valor1 * valor2;
//                    Console.WriteLine("O resultado da multiplicação é igual a: " + resultado);
//                    break;
//                case 4:
//                    resultado = valor1 / valor2;
//                    Console.WriteLine("O resultado da divisão é igual a: " + resultado);
//                    break;
//                case 99:
//                    Console.WriteLine("Saindo da calculadora...");
//                    break;
//            }
//        }
//        while (opcao != 99);
//    }
//}