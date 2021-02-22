using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculoIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            bool dataNascimentoEhValida = false;
            DateTime dataNascimento = DateTime.Now;
            string nome = "";

            System.Console.WriteLine("Informe seu nome:");
            nome = Console.ReadLine();
            while (!dataNascimentoEhValida)
            {
            // declarar variaveis de entrada ..
            int dia, mes, ano;
            // fazer a leitura dos dados de entrada e fazer suas validacoes .
            dia = LeiaValorNumerico("Informe o dia do nascimento: ");
            mes = LeiaValorNumerico("Informe o mes do nascimento: ");
            ano = LeiaValorNumerico("Informe o ano do nascimento: ");

            try
            {
                dataNascimento = new DateTime(ano,mes,dia);

                dataNascimentoEhValida = true;
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("Data de nascimento invalida.");    
            
            }
            }

            //calcular a idade do usuario..
            var idadeUsuario = (int)(DateTime.Today.Subtract(dataNascimento).TotalDays/365);
            var idadeEmDias = DateTime.Today.Subtract(dataNascimento).TotalDays;


            // exibir a idade do usuario
            Console.Clear();
            Console.WriteLine("");
            System.Console.WriteLine($"{nome} voce tem {idadeUsuario} anos de idade...");
            System.Console.WriteLine($"{nome} sua idade em dias é: {idadeEmDias}");

            
        }
        // recebe e valida se o valor informado eh valido ...
        static int LeiaValorNumerico(string mensagemAoUsuario)
        {            
            bool numeroEhValido = false;

            int numeroInformado = 0;

            while (!numeroEhValido)
            {
                System.Console.WriteLine(mensagemAoUsuario);
                
                var valorInformado = Console.ReadLine();

                numeroEhValido = int.TryParse(valorInformado, out numeroInformado);

                if(!numeroEhValido)
                {
                    System.Console.WriteLine("Numero é invalido.");
                }
            }
            return numeroInformado;
            

            
        }
    }
}
