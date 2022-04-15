using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, mundo!");
            Console.WriteLine(123);
            Console.WriteLine(10.5);
            Console.WriteLine(true);

            //Toda classe do C# deriva do tipo object por padrão
            object conta = new ContaCorrente(456, 687876);
            Console.WriteLine(conta);

            string contaToString = conta.ToString();
            Console.WriteLine("Resultado: " + contaToString);

            // Desenvolvedor deriva da classe Funcionário, que por sua vez deriva do tipo object por padrão
            object desenvolvedor = new Desenvolvedor("");
            Console.WriteLine(desenvolvedor);





            Cliente carlos_1 = new Cliente();
            carlos_1.Nome = "Carlos";
            carlos_1.CPF = "458.623.120-03";
            carlos_1.Profissao = "Designer";
            
            Cliente carlos_2 = new Cliente();
            carlos_2.Nome = "Carlos";
            carlos_2.CPF = "458.623.120-03";
            carlos_2.Profissao = "Designer";

            // Comparando duas referências diferentes, então não são iguais.
            if (carlos_1 == carlos_2)
            {
                Console.WriteLine("São iguais!");
            }
            else
            {
                Console.WriteLine("Não são iguais!");
            }

            // O método Equals() foi implementado na classe object e serve para comparar dois objetos.
            // Na classe Cliente, esse método foi sobrescrito para comparar os dois objetos que criamos!
            if (carlos_1.Equals(carlos_2))
            {
                Console.WriteLine("São iguais!");
            }
            else
            {
                Console.WriteLine("Não são iguais!");
            }

            ContaCorrente conta2 = new ContaCorrente(1658, 64187);
            // O método Equals() na classe Cliente tenta a conversão do objeto passado como parâmetro para o tipo Cliente.
            // Quando isso não é possível, o método já retorna false, que é o que ocorre neste caso.
            if (carlos_1.Equals(conta2))
            {
                Console.WriteLine("São iguais!");
            }
            else
            {
                Console.WriteLine("Não são iguais!");
            }



            Console.ReadLine();
        }

        static void TestaString()
        {
            // Expressões regulares
            // string padrao = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
            // string padrao = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            // string padrao = "[0-9]{4,5}[-][0-9]{4}"; -> Pega os números de celular (9 números) e fixo (8 números)
            // string padrao = "[0-9]{4,5}-{0,1}[0-9]{4}"; -> Pega números com e sem hífen
            string padrao = "[0-9]{4,5}-?[0-9]{4}"; // Expressão mais otimizada

            string textoDeTeste = "Meu nome é Bruno, me ligue em 91234-5678";

            Match resultado = Regex.Match(textoDeTeste, padrao);

            Console.WriteLine(resultado.Value);
            Console.ReadLine();




            // Testando métodos StartsWith, EndsWith, Contains
            string urlTeste = "https://bytebank.com/cambio";
            int indiceByteBank = urlTeste.IndexOf("https://bytebank.com");

            Console.WriteLine(urlTeste.StartsWith("https://bytebank.com"));
            Console.WriteLine(urlTeste.EndsWith("cambio/"));

            Console.WriteLine(urlTeste.Contains("bytebank")); // True
            Console.WriteLine(urlTeste.Contains("ByteBank")); // False

            Console.ReadLine();




            //pagina?argumentos
            // +---+---+---+---+---+---+---+---+---+---+----+----+----+----+----+----+----+
            // | p | a | g | i | n | a | ? | a | r | g | u  | m  | e  | n  | t  | o  | s  |
            // | 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 | 11 | 12 | 13 | 14 | 15 | 16 |
            // +---+---+---+---+---+---+---+---+---+---+----+----+----+----+----+----+----+




            // Testando e refinando o método ExtratorValorDeArgumentosURL.GetValor()
            string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);

            string valor = extratorDeValores.GetValor("moedaOrigem");
            Console.WriteLine("Valor de moedaOrigem: " + valor);

            string valor2 = extratorDeValores.GetValor("moedaDESTINO");
            Console.WriteLine("Valor de moedaDestino: " + valor2);

            Console.WriteLine(extratorDeValores.GetValor("VALOR"));

            Console.ReadLine();




            // Testando ToUpper()
            string mensagemOrigem = "PALAVRA";
            string termoBusca = "ra";

            termoBusca = termoBusca.ToUpper();
            Console.WriteLine(termoBusca);
            Console.WriteLine(mensagemOrigem.IndexOf(termoBusca));
            Console.ReadLine();




            // Testando o método remove
            string testeRemocao = "primeiraParte&parteParaRemover";
            int indiceEComercial = testeRemocao.IndexOf('&');
            Console.WriteLine(testeRemocao.Remove(indiceEComercial));
            Console.ReadLine();




            // <nome>=<valor>
            string palavra = "moedaOrigen=moedaDestino&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino=";

            int indice = palavra.IndexOf(nomeArgumento);
            Console.WriteLine(indice);

            Console.WriteLine("Tamanho da string nomeArgumento: " + nomeArgumento.Length);

            Console.WriteLine(palavra);
            Console.WriteLine(palavra.Substring(indice));
            Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length));
            Console.ReadLine();




            // Testando o IsNullOrEmpty
            string textoVazio = "";
            string textoNulo = null;
            string textoQualquer = "asfdgasd";
            Console.WriteLine(String.IsNullOrEmpty(textoVazio));
            Console.WriteLine(String.IsNullOrEmpty(textoNulo));
            Console.WriteLine(String.IsNullOrEmpty(textoQualquer));
            Console.ReadLine();




            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL("");

            string url = "pagina?moedaOrigem=real&moedaDestino=dolar";

            int indiceInterrogacao = url.IndexOf('?');

            Console.WriteLine(indiceInterrogacao);

            Console.WriteLine(url);
            string argumentos = url.Substring(indiceInterrogacao + 1);
            Console.WriteLine(argumentos);

            Console.ReadLine();
        }
    }
}
