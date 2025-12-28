using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_exercicios.Funcionario
{
    internal class Funcionario
    {
        public string nome; // criando atributos
        public string sobreNome;
        public string email;

        public int numeroDeHorasTrabalhadas;
        public double salario;
        public double horarioTaxa;
        const int unidadeDeHorasTrabalhadasMinima = 1; // constante para representar a unidade mínima de horas trabalhadas
        public DateTime dataDeAniversario;

        public Funcionario(string nomefuncionario, string sobre, string em, DateTime da) : this(nomefuncionario, sobre, em, da, 0) // construtor que inicializa os atributos da class
        {

        }
        public Funcionario(string nomefuncionario, string sobre, string em, DateTime da, double taxa)
        {
            nome = nomefuncionario;
            sobreNome = sobre;
            email = em;
            dataDeAniversario = da;
            horarioTaxa = taxa;
        }

        public void ExecutarTrabalho() // método para realizar o trabalho, contabilizando as horas trabalhadas
        {
            //numeroDeHorasTrabalhadas++; // incrementa 1 hora trabalhada toda vez que o método é chamado

            ExecutarTrabalho(unidadeDeHorasTrabalhadasMinima); // chama o método sobrecarregado para contabilizar 1 hora trabalhada

            //Console.WriteLine($"{nome} {sobreNome} trabalhou por {numberOfHoursWorked} hora(s)!");
        }
        public void ExecutarTrabalho(int numeroDeHoras) // método sobrecarregado para contabilizar várias horas trabalhadas
        {
            numeroDeHorasTrabalhadas += numeroDeHoras; // incrementa o número de horas trabalhadas com base no numberOfHours fornecido
            Console.WriteLine($"{nome} {sobreNome} trabalhou por {numeroDeHorasTrabalhadas} hora(s)!");
        }

        public double ReceberSalario(bool resetarHoras = true) // método para calcular o salário com base nas horas trabalhadas e na taxa horária e resetar as horas trabalhadas se necessário
        {
            salario = numeroDeHorasTrabalhadas * horarioTaxa; // calculo para obter o salário

            Console.WriteLine($"{nome} {sobreNome} recebeu {salario} por {numeroDeHorasTrabalhadas} hora(s) de trabalho."); // exibe o salário recebido e as horas trabalhadas

            if (resetarHoras) // verifica se deve resetar as horas trabalhadas
            {
                numeroDeHorasTrabalhadas = 0; // reseta as horas trabalhadas para 0
            }

            return salario; // retorna o salário calculado
        }

        public void DetalhesDoFuncionario() // método para exibir os detalhes do funcionário
        {
            Console.WriteLine($"Detalhes do Funcionário:");
            Console.WriteLine($"Nome: {nome} {sobreNome}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Data de Aniversario: {dataDeAniversario.ToShortDateString()}");
        }
    }
}
