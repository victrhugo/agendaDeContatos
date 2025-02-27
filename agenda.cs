using Microsoft.Extensions.Options;
using System;

namespace AgendaDeContatos
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AgendaContext())
            {
                

                
            }

            Agenda agenda = new Agenda();
            string opcao;

            do
            {
                Console.WriteLine("Agenda de Contatos (SQL Server)");
                Console.WriteLine("1. Adicionar Contato");
                Console.WriteLine("2. Listar Contatos");
                Console.WriteLine("3. Buscar Contato");
                Console.WriteLine("4. Sair");
                Console.Write("Escolha uma opção: ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Telefone: ");
                        string telefone = Console.ReadLine();
                        Console.Write("Email: ");
                        string email = Console.ReadLine();
                        agenda.AdicionarContato(new Contato { Nome = nome, Telefone = telefone, Email = email });
                        break;
                    case "2":
                        agenda.ListarContatos();
                        break;
                    case "3":
                        Console.Write("Digite o nome para busca: ");
                        string busca = Console.ReadLine();
                        agenda.BuscarContato(busca);
                        break;
                    case "4":
                        Console.WriteLine("Encerrando aplicação...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!\n");
                        break;
                }
            } while (opcao != "4");
        }
    }
}
