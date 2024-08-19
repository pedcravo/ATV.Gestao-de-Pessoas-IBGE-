/*
Cenário: Gestão de Pessoas no “IBGE” -> 
Escreva um algoritmo que receba a idade de um grupo de pessoas, calcule 
e imprima a porcentagem de cada faixa etária em relação ao total de 
pessoas.

As faixas etárias são:
    • 01 - 15 anos - A
    • 16 - 30 anos - B
    • 31 - 45 anos - C
    • 46 - 60 anos - D
    • >= 61 anos - E
Para encerrar a entrada de dados, digite uma idade <= 0
*/

namespace GestaoDePessoas
{
    internal class Program
    {
        static void Main()
        {
            int idade, pessoas = 0;
            int A = 0, B = 0, C = 0, D = 0, E = 0;
            int i;

            do
            {
                Console.WriteLine("Adicione uma pessoa ao nosso banco de dados, adicione a idade:");
                idade = int.Parse(Console.ReadLine());
                pessoas++;

                switch (idade)
                {
                    case <= 0:
                        i = 0;
                        pessoas--;
                        break;
                    
                    case >= 1 and <= 15:
                        i = 1;
                        A++;
                        break;

                    case >= 16 and <= 30:
                        i = 1;
                        B++;
                        break;

                    case >= 31 and <= 45:
                        i = 1;
                        C++;
                        break;
                    
                    case >= 46 and <= 60:
                        i = 1;
                        D++;
                        break;

                    case >= 61:
                        i = 1;
                        E++;
                        break;
                }
            } while (i == 1);


            Console.WriteLine("A porcentagem das faixas etárias é:");
            Console.WriteLine("A (1 a 15)  = " + (100 * A) / pessoas + "%");
            Console.WriteLine("B (16 a 30) = " + (100 * B) / pessoas + "%");
            Console.WriteLine("C (31 a 45) = " + (100 * C) / pessoas + "%");
            Console.WriteLine("D (46 a 50) = " + (100 * D) / pessoas + "%");
            Console.WriteLine("E  (61 +)   = " + (100 * E) / pessoas + "%");
        }
    }
}
