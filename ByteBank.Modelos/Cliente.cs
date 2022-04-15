using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class Cliente
    {
        public string Nome { get; set; }

        private string _cpf;
        public string CPF
        {
            get
            {
                return _cpf;
            }
            set
            {
                // Escrevo minha lógica de validação de CPF
                _cpf = value;
            }
        }
        public string Profissao { get; set; }

        public override bool Equals(object obj)
        {
            // Cliente outroCliente = (Cliente)obj; -> Este cast retorna uma exceção quando não é bem sucedido.
            Cliente outroCliente = obj as Cliente; // Fazendo desta maneira, é retornado null caso o cast não tenha sucesso.

            if (outroCliente == null)
            {
                return false;
            }

            return this.CPF == outroCliente.CPF;
            // return this.Nome == outroCliente.Nome && this.CPF == outroCliente.CPF && this.Profissao == outroCliente.Profissao;
        }
    }
}
