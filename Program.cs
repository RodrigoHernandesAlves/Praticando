using System;

namespace Exercicio_de_orientacao_a_objetos_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Receita chocolate = new Receita(); // estancia receita
            chocolate.peso = 1.9m;
            chocolate.tamanho = "Grande";
            chocolate.preco = 35.00m;
            chocolate.Nome= "Bolo de chocolate";

            Receita morango = new Receita();
            morango.peso = 1.5m;
            morango.tamanho = "Medio";
            morango.preco = 25.00m;
            morango.Nome = "Bolo de morango";

            Receita abacaxi = new Receita();
            abacaxi.peso = 1.2m;
            abacaxi.tamanho = "Pequeno";
            abacaxi.preco = 15.00m;
            abacaxi.Nome = "Bolo de abacaxi";

        }
    }
}
