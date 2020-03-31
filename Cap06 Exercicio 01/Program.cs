using System;

namespace Cap06_Exercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             A dona de um pensionato possui dez quartos para alugar para estudantes,
                sendo esses quartos identificados pelos números 0 a 9.
                Quando um estudante deseja alugar um quarto, deve-se registrar o nome
                e email deste estudante.
                Fazer um programa que inicie com todos os dez quartos vazios, e depois
                leia uma quantidade N representando o número de estudantes que vão
                alugar quartos (N pode ser de 1 a 10). Em seguida, registre o aluguel dos
                N estudantes. Para cada registro de aluguel, informar o nome e email do
                estudante, bem como qual dos quartos ele escolheu (de 0 a 9). Suponha
                que seja escolhido um quarto vago. Ao final, seu programa deve imprimir
                um relatório de todas ocupações do pensionato, por ordem de quarto,
                conforme exemplo.
             */

            int nMaxQuarto = 10;

            Console.Write("Informe quantos quartos gostaria de reservar? ");
            int quarto = int.Parse(Console.ReadLine());


            Estudante[] vect = new Estudante[nMaxQuarto];

            for (int i = 0; i < quarto; i++)
            {
                Console.WriteLine("Reserva #{0}:", i + 1);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quart = int.Parse(Console.ReadLine());
                Console.WriteLine();

                vect[quart] = new Estudante(nome, email, quart);

            }

            Console.WriteLine("Quartos Reservados");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                    Console.WriteLine(vect[i]);
            }










        }
    }
}
