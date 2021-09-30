using Calculo;
using Diretorio;
using Funcoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela
{
    class Menu
    {
        /// <summary>
        ///  PROGRAMAÇÃO ORIENTADA A FUNÇÃO
        /// </summary>
        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVO = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEIDA = 3;

        public static void Criar()
        {
            //Variável Constante


            while (true)
            {
                string mensagem = "Olá usuário, bem vindo ao programa\n" +
                    "\n   Utilizando programação funcional" +
                    "\n" +
                    "\n        Digite uma das opções abaixo:" +
                    "\n         0  - Sair do programa" +
                    "\n         1  - Para ler arquivos" +
                    "\n         2  - Para execultar a tabuada" +
                    "\n         3  - Calcular a média de alunos";

                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());
                if (valor == SAIDA_PROGRAMA)
                    break;
                else if (valor == LER_ARQUIVO)
                {
                    Console.WriteLine("======================= Opção Ler Arquivos =============================");
                    Arquivo.Ler(1);
                    Console.WriteLine("\n=================================================================================================================\n");
                }

                else if (valor == TABUADA)
                {
                    Console.WriteLine("======================= Opção Tabuada =============================");
                    Console.WriteLine("Digite o número que deseja na tabuada:");
                    int num = int.Parse(Console.ReadLine());
                    Tabuada.Calcular(num);
                    Console.WriteLine("\n=================================================================================================================\n");

                }
                else if (valor == CALCULO_MEIDA)
                {
                    Console.WriteLine("======================= Opção Calculo da Média =============================");
                    Media.Alunos();

                }
            }
        }
    }
}
