using System;

namespace agenda
{
    class Program
    {
        static void Main(string[] args)
        {
         string nome, email, endereco;
         char fim = 's';

         Contato novoContato = new Contato();
            do{
                 Console.WriteLine("== Agenda de Contatos==");
                 Console.WriteLine("Digite um Nome: ");
                 nome = Console.ReadLine();
                 Console.WriteLine("Digite um Email ");
                 email = Console.ReadLine();
                 Console.WriteLine("Digite um Endereço: ");
                 endereco = Console.ReadLine();

                 ItemContato novoItemContato = new ItemContato(nome, email, endereco);
                 novoContato.adicionaContato(novoItemContato);

                 Console.WriteLine("Deseja Continuar S ou N");
                 fim = Convert.ToChar(Console.ReadLine());
            }while(fim == 's');

            Console.WriteLine("Total De Contatos: " + novoContato.TotalContatos()); 


        }
    }
}
