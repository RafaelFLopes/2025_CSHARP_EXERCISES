using System;
using System.Reflection.PortableExecutable;

class imc
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculando IMC");

        Console.Write("Digite sua altura (ex: 1.75): ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Digite seu peso (ex: 84): ");
        double p = double.Parse(Console.ReadLine());

        double resultado = calculo(a, p);

        Console.WriteLine("Seu IMC é: " + resultado);
    }
    static double calculo(double a, double p)
    { 

        double imc = p / (a * a);

        return imc;
    }
}