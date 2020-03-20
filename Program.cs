using System;
using System.Globalization; // <- Para utilizar o objeto CultureInfo

namespace at02
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaração das variáveis
            String nome;
            String senha;
            int idade;
            DateTime nascimento;
            DateTime hoje;
            CultureInfo cultura;

            //Readline -> comando de leitura do nome
            Console.WriteLine("Digite o seu nome");
            nome = Console.ReadLine();

            // Leitura do nome e criação do objeto DateTime
            Console.WriteLine("Digite a sua data de nascimento(dd/mm/aaaa)");
            cultura = new CultureInfo("pt-BR");
            nascimento = Convert.ToDateTime(Console.ReadLine(), cultura);

            // Cálculo da idade
            hoje = DateTime.Today;
            idade = hoje.Year - nascimento.Year;
            if (hoje.Month < nascimento.Month || (hoje.Month == nascimento.Month && hoje.Day < nascimento.Day)){
                idade--;
            }

            // Condição se tiver 18 ou mais
            if(idade >= 18){
                senha = nome+idade;
            } else {
                senha = idade+nome;
            }

            //Writeline -> Comando de escrita
            Console.WriteLine("Sua senha forte é" + senha);

        }
    }
}
