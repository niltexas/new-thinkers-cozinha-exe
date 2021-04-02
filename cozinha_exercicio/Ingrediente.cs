using System;
using System.Collections.Generic;
using System.Text;

namespace cozinha_exercicio
{
    public class Ingrediente
    {
        public string Nome;
        public DateTime DataValidade;

        public Ingrediente(string nome, DateTime dataValidade)
        {
            Nome = nome;
            DataValidade = dataValidade;
        }

    }

}
