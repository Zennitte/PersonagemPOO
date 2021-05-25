using System;

namespace Personagem_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem personagem1 = new Personagem();
            personagem1.nome = "Thor";
            personagem1.idade = 1500;
            personagem1.armadura = "Mjolnir";
            personagem1.pontoVida = 100;
            // personagem1.forca = 15;

            Personagem personagem2 = new Personagem();
            personagem2.nome = "Doutor Estranho";
            personagem2.idade = 50;
            personagem2.armadura = "Manto";
            personagem2.pontoVida = 80;
            // personagem1.forca = 10;

            do
            {
                Console.WriteLine(@"
            Selecione a ação do personagem 1
            1 - Atacar
            2 - Defender");

                int opcao1 = int.Parse(Console.ReadLine());

                Console.WriteLine(@"
            Selecione a ação do personagem 2
            1 - Atacar
            2 - Defender");

                int opcao2 = int.Parse(Console.ReadLine());

                if (opcao1 == 1 && opcao2 == 1)
                {
                    personagem1.pontoVida = personagem1.pontoVida - personagem2.Atacar();

                    personagem2.pontoVida = personagem2.pontoVida - personagem1.Atacar();
                }
                else if (opcao1 == 1 && opcao2 == 2)
                {
                    personagem2.pontoVida = personagem2.pontoVida - (personagem1.Atacar() - personagem2.Defender());
                }
                else if (opcao1 == 2 && opcao2 == 1)
                {
                    personagem1.pontoVida = personagem1.pontoVida - (personagem2.Atacar() - personagem1.Defender());
                }
                else if (opcao1 == 2 && opcao2 == 2)
                {

                }

                Console.WriteLine($"Vida do {personagem1.nome}: {personagem1.pontoVida}");
                Console.WriteLine($"Vida do {personagem2.nome}: {personagem2.pontoVida}");
                
            } while (personagem1.pontoVida > 0 && personagem2.pontoVida > 0);


        }
    }
}
