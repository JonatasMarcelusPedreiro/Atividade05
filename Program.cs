using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade05
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string nome2;
            string endereço;
            string bairro;
            string cidade;
            string estado;

            Console.WriteLine(" Olá! nós somos a MIlHAS uma agencia de viagens e turismos \n");
            Console.WriteLine(" Para começar o cadastro digite seu PRIMEIRO NOME:");
            nome = Console.ReadLine();

            Console.WriteLine(" Agora digite seu SEGUNDO NOME:");
            nome2 = Console.ReadLine();

            Console.WriteLine($" Olá, Sr(a).{nome} {nome2}, vamos continuar seu cadastro... \n ");

            Console.WriteLine($"Qual é o seu endereço?");
            endereço = Console.ReadLine();

            Console.WriteLine(" Qual é o seu bairro? ");
            bairro = Console.ReadLine();

            Console.WriteLine(" Qual é a sua cidade? ");
            cidade = Console.ReadLine();

            Console.WriteLine(" Qual o seu estado? ");
            estado = Console.ReadLine();


            Console.WriteLine($" Sr(a). {nome2}  mora na cidade de {cidade} - {estado}, no {endereço}, " +
                $"localizado no bairro {bairro} ");


            int viagens;
            int planejadas;

            Console.WriteLine(" Quantas viagens você fez ano passado? ");
            viagens=Int32.Parse(Console.Readline());

            Console.WriteLine(" Quantas viagens você planejou fazer esse ano?")
                planejadas= Int32.Parse(Console.ReadLine());

            Console.WriteLine($" Você fez um total de {viagens + planejadas} entre 2022 e 2023");
            Console.WriteLine($" Faltam {viagens + planejadas / 10 } para completar 10 viagens");

            Console.WriteLine($"Você fez em média {viagens + planejadas / 2} viagens  ");


            string cupom;
            string aceitar;

            Console.WriteLine(" Agora digite seu cupom de desconto para sua próxima viagem:");
            cupom= Console.ReadLine();

            if (cupom == " Conradito10")
            {
                Console.WriteLine(" Parabéns, você recebeu 10% de desconto na sua próxima viagem");

                    else
                {
                    Console.WriteLine(" Este cupom não existe");


                }


            }

            Console.WriteLine(" Você gostaria de receber promoções no seu e-mail? ?");
            if (aceitar == "sim")
            {
                Console.WriteLine($" Obrigado {nome} por se registrar, você receberá novos e-mails em breve.");

                 else
                {
                    Console.WriteLine(" Ok, você não receberá e-mails de promoções.");
                }
    }
}
