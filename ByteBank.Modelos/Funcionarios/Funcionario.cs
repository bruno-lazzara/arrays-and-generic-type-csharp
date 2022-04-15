using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }
        // O modificador de acesso protected utilizado acima ^ permite que o setter desta característica
        // seja acessado também pelas classes derivadas da classe Funcionaio (como Diretor, ou outras
        // que podem ser criadas futuramente). Se o setter fosse private, apenas a classe base poderia executá-lo.

        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando FUNCIONARIO");

            Salario = salario;
            CPF = cpf;

            TotalDeFuncionarios++;
        }

        // Definimos esses dois métodos seguintes como abstratos.
        // Isso nos obriga a criarmos estes métodos dentro das novas classes de
        // funcionários que criarmos futuramente, para evitarmos o erro da não
        // implementação destes métodos.
        public abstract void AumentarSalario();

        internal protected abstract double GetBonificacao();
    }
}
