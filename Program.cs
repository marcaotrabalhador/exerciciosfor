using System;

class Program
{
    static void Main()
    {
        int countMaioresIdade = 0;

        for (int i = 1; i <= 20; i++)
        {
            Console.Write("Digite a idade da pessoa {0}: ", i);
            int idade = Convert.ToInt32(Console.ReadLine());

            if (idade >= 18)
            {
                countMaioresIdade++;
            }
        }

        Console.WriteLine("O número de pessoas maiores de idade é: " + countMaioresIdade);
    }
}
