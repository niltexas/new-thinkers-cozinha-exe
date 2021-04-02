using System;

namespace cozinha_exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando os trabalhos do restaurante");

            #region Cozinha Mineira
            Cozinha cozinhaMineira = new Cozinha();
            cozinhaMineira.Tipo = "Mineira";
            cozinhaMineira.TempoPreparo = 30;
            cozinhaMineira.NumeroCozinheiros = 5;
            cozinhaMineira.getNumeroPratos();
            cozinhaMineira.setNumeroPratos(10);
            cozinhaMineira.HoraAbertura = 14;
            cozinhaMineira.HoraFechamento = 20;
            cozinhaMineira.PratoPrincipal = "Feijoada";

       
            cozinhaMineira.Ingredientes.Add(new Ingrediente("Feijão", DateTime.Now.AddDays(60)));
            cozinhaMineira.Ingredientes.Add(new Ingrediente("Farinha", DateTime.Now.AddDays(120)));
            cozinhaMineira.Ingredientes.Add(new Ingrediente("Arroz", DateTime.Now.AddDays(120)));
            cozinhaMineira.Ingredientes.Add(new Ingrediente("Carne de Porco", DateTime.Now.AddDays(30)));
            cozinhaMineira.Ingredientes.Add(new Ingrediente("Linguiça", DateTime.Now.AddDays(40)));
         
            cozinhaMineira.Funcionarios.Add(new Funcionario("Pelé", "Maitre"));
            cozinhaMineira.Funcionarios.Add(new Funcionario("Neymar", "Garçom"));
            cozinhaMineira.Funcionarios.Add(new Funcionario("Eren", "Ajudante"));
            cozinhaMineira.Funcionarios.Add(new Funcionario("Apolo", "Lavador de Pratos"));
            #endregion

            #region Cozinha Italiana
            Cozinha cozinhaItaliana = new Cozinha();
            cozinhaItaliana.Tipo = "Italiana";
            cozinhaItaliana.TempoPreparo = 50;
            cozinhaItaliana.NumeroCozinheiros = 2;
            cozinhaItaliana.getNumeroPratos();
            cozinhaItaliana.setNumeroPratos(6);
            cozinhaItaliana.HoraAbertura = 13;
            cozinhaItaliana.HoraFechamento = 22;
            cozinhaItaliana.PratoPrincipal = "Macarronada";

          
            cozinhaItaliana.Ingredientes.Add(new Ingrediente("Molho", DateTime.Now.AddDays(15)));
            cozinhaItaliana.Ingredientes.Add(new Ingrediente("Macarrão", DateTime.Now.AddDays(365)));
            cozinhaItaliana.Ingredientes.Add(new Ingrediente("Carne", DateTime.Now.AddDays(30)));
           
            cozinhaItaliana.Funcionarios.Add(new Funcionario("Jacquin", "Cheff"));
            cozinhaItaliana.Funcionarios.Add(new Funcionario("Tarantino", "Garçom"));
            #endregion

            #region Cozinha Chinesa
            Cozinha cozinhaChinesa = new Cozinha();
            cozinhaChinesa.Tipo = "Chinesa";
            cozinhaChinesa.TempoPreparo = 30;
            cozinhaChinesa.NumeroCozinheiros = 3;
            cozinhaChinesa.getNumeroPratos();
            cozinhaChinesa.setNumeroPratos(4);
            cozinhaChinesa.HoraAbertura = 10;
            cozinhaChinesa.HoraFechamento = 21;
            cozinhaChinesa.PratoPrincipal = "Yakissoba";

           
            cozinhaChinesa.Ingredientes.Add(new Ingrediente("Champignon", DateTime.Now.AddDays(30)));
            cozinhaChinesa.Ingredientes.Add(new Ingrediente("Brócolis", DateTime.Now.AddDays(15)));
            cozinhaChinesa.Ingredientes.Add(new Ingrediente("Macarrão", DateTime.Now.AddDays(365)));
            cozinhaChinesa.Ingredientes.Add(new Ingrediente("Carne", DateTime.Now.AddDays(30)));
           
            cozinhaChinesa.Funcionarios.Add(new Funcionario("Nina", "Cheff"));
            cozinhaChinesa.Funcionarios.Add(new Funcionario("Riquelme", "Garçom"));
            cozinhaChinesa.Funcionarios.Add(new Funcionario("Carluxo", "Lixeiro"));
            #endregion 


        }
    }
}

