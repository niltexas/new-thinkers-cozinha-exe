using System;
using System.Collections.Generic;
using System.Text;


namespace cozinha_exercicio
{
    public class Cozinha
    {
        private int NumeroPratos;
        public string Tipo;
        public int NumeroCozinheiros;
        public int TempoPreparo;
        public int HoraAbertura;
        public int HoraFechamento;
        public string PratoPrincipal;

        public List<Ingrediente> Ingredientes = new List<Ingrediente>();
        public List<Funcionario> Funcionarios = new List<Funcionario>();




        public int getNumeroPratos()
        {
            return NumeroPratos;
        }

        public void setNumeroPratos(int n)
        {
            NumeroPratos = n;
        }

        public void preprarPratos()
        {

        }

        public void lavarLouca()
        {

        }
    }
}
