using System;

namespace Cap06_Exercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int nMaxQuarto = 10;

            Console.Write("Informe quantos quartos gostaria de reservar? ");
            int quarto = int.Parse(Console.ReadLine());


            Estudante[] vect = new Estudante[nMaxQuarto];

            for (int i = 0; i < quarto; i++)
            {
                Console.WriteLine("Reserva #{0}:", i+1);
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
                if (vect[i]!= null)
                    Console.WriteLine(vect[i]);

            }










        }
    }
}
