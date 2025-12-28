using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_exercicios.Funcionario
{
    internal class arquivoPrincipal
    {
        public static void Main(string[] args) { 
            Console.WriteLine("Criando um funcionário");
            Console.WriteLine("-----------------------");

            Funcionario bethany = new Funcionario("Bethany", "Smith", "bethany.smith@gmail.com", new DateTime(1995, 09, 13), 25); // cria uma nova instância da classe Employee com os detalhes fornecidos

            bethany.DetalhesDoFuncionario(); // os detalhes do funcionário são exibidos

            bethany.ExecutarTrabalho(); // chama o método para contabilizar 1 hora trabalhada
            bethany.ExecutarTrabalho(); // chama o método para contabilizar 1 hora trabalhada
            bethany.ExecutarTrabalho(); // chama o método para contabilizar 1 hora trabalhada
            bethany.ExecutarTrabalho(); // chama o método para contabilizar 1 hora trabalhada

            //totalizando 8 horas trabalhadas

            double recebeuOSalario = bethany.ReceberSalario(); // chama o método para calcular e exibir o salário recebido por Bethany

            Console.WriteLine($"Salario: {recebeuOSalario}"); // exibe o salário recebido por Bethany
        }
    }
}
