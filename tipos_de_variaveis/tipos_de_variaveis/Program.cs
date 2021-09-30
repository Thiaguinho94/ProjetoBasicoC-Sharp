using Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Tela;

namespace tipos_de_variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Menu.Criar();
            var cliente = new Cliente();
            cliente.Nome = "Geraldo";
            cliente.Telefone = "870089127309128";
            cliente.CPF = "10101010101";
            cliente.Gravar();




            var clientes = Cliente.LerClientes();
            foreach  (Cliente c in clientes)
            {
                Console.WriteLine(c.Nome);
                Console.WriteLine(c.Telefone);
                Console.WriteLine(c.CPF);
                
                
                Console.WriteLine("===================================");


            }
            Console.ReadLine();
           
        }
    }
}
