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
            Lista<int> idades = new Lista<int>();

            //A lista 'idades' foi criada como sendo do tipo int.
            //Portanto, não poderá receber parâmetros de outros tipos.
            //idades.Adicionar("texto qualquer"); - NÃO COMPILA

            idades.Adicionar(5);
            idades.AdicionarVarios(1, 5, 78);

            for (int i = 0; i < idades.Tamanho; i++)
            {
                int idadeAtual = idades[i];
            }




            Console.ReadLine();
        }

        static void TesteListaDeObject()
        {
            ListaDeObject listaDeIdades = new ListaDeObject();

            listaDeIdades.Adicionar(10);
            listaDeIdades.Adicionar(5);
            listaDeIdades.Adicionar(4);
            listaDeIdades.AdicionarVarios(16, 23, 60);

            for (int i = 0; i < listaDeIdades.Tamanho; i++)
            {
                int idade = (int)listaDeIdades[i];
                Console.WriteLine($"Idade no índice {i}: {idade}");
            }





            Console.WriteLine(SomarVarios(1, 2, 3, 4, 5, 6, 7, 8, 9));
            Console.WriteLine(SomarVarios(1, 2, 3));



            Console.ReadLine();
        }

        static void TesteListaDeContaCorrente()
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            ContaCorrente contaDeBruno = new ContaCorrente(010101, 3654260);

            ContaCorrente[] contas = new ContaCorrente[]
            {
                contaDeBruno,
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5546678)
            };

            lista.AdicionarVarios(contas);

            //A palavra chave 'params'escrita na criação do método faz com que
            //o AdicionarVarios primeiro crie uma array com os parâmetros inseridos
            //abaixo, para depois chamar o método como ele foi chamado acima.
            lista.AdicionarVarios(
                contaDeBruno,
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679787)
                );

            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Agencia} / {itemAtual.Numero}");
            }

            //lista.EscreverListaNaTela();

            //lista.Remover(contaDeBruno);

            //Console.WriteLine("Após remover o item");
            //lista.EscreverListaNaTela();




            Console.ReadLine();
        }

        static void TestaArrayDeContaCorrente()
        {

            ContaCorrente[] contas = new ContaCorrente[]
            {
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5546678),
                new ContaCorrente(874, 7781438)
            };


            for (int i = 0; i < contas.Length; i++)
            {
                Console.WriteLine($"Conta {i} {contas[i].Numero}");
            }


            Console.ReadLine();
        }

        static void TestaArrayIndice()
        {
            //ARRAY de inteiros com 5 posições
            int[] idades = null;
            idades = new int[3];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            //idades[3] = 50;
            //idades[4] = 28;
            //idades[5] = 60;

            Console.WriteLine(idades.Length);

            int acumulador = 0;
            for (int i = 0; i < idades.Length; i++)
            {
                int idade = idades[i];

                Console.WriteLine($"Acessando  o array idades no índice {i}");
                Console.WriteLine($"Valor de idades[{i}] = {idade}");

                acumulador += idade;
            }

            int media = acumulador / idades.Length;
            Console.WriteLine($"Média de idades = {media}");




            Console.ReadLine();
        }

        //Outro exemplo do uso de params
        static int SomarVarios(params int[] numeros)
        {
            int acumulador = 0;
            foreach (int numero in numeros)
            {
                acumulador += numero;
            }
            return acumulador;
        }
    }
}