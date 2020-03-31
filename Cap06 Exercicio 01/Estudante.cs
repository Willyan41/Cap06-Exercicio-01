using System;
using System.Collections.Generic;
using System.Text;

namespace Cap06_Exercicio_01
{
    class Estudante
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Quarto { get; set; }

        public Estudante(string nome, string email, int quarto)
        {
            Nome = nome;
            Email = email;
            Quarto = quarto;
        }

        public override string ToString()
        {
            return
                Quarto +
                ": " +
                Nome +
                ", " +
                Email;
        }


    }
}
