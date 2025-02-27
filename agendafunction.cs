using System;
using System.Linq;

namespace AgendaDeContatos
{
    public class Agenda
    {
        public void AdicionarContato(Contato contato)
        {
            using (var context = new AgendaContext())
            {
                context.Contatos.Add(contato);
                context.SaveChanges();
                Console.WriteLine("Contato adicionado com sucesso!\n");
            }
        }

        public void ListarContatos()
        {
            using (var context = new AgendaContext())
            {
                var contatos = context.Contatos.ToList();

                if (contatos.Count == 0)
                {
                    Console.WriteLine("Nenhum contato cadastrado.\n");
                    return;
                }

                Console.WriteLine("Lista de Contatos:");
                foreach (var contato in contatos)
                {
                    Console.WriteLine($"ID: {contato.Id} | Nome: {contato.Nome} | Telefone: {contato.Telefone} | Email: {contato.Email}");
                }
                Console.WriteLine();
            }
        }

        public void BuscarContato(string nome)
        {
            using (var context = new AgendaContext())
            {
                var encontrados = context.Contatos.Where(c => c.Nome.Contains(nome)).ToList();

                if (encontrados.Count == 0)
                {
                    Console.WriteLine("Nenhum contato encontrado.\n");
                    return;
                }

                Console.WriteLine("Contatos encontrados:");
                foreach (var contato in encontrados)
                {
                    Console.WriteLine($"ID: {contato.Id} | Nome: {contato.Nome} | Telefone: {contato.Telefone} | Email: {contato.Email}");
                }
                Console.WriteLine();
            }
        }
    }
}

