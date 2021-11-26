using System;
using System.Globalization;

namespace AppVetorExercicio01
{
    /// <summary>
    /// Exercícios - 01 Vetores
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, entre com o número de pessoas e a altura de cada uma: ");
            
            int n = int.Parse(Console.ReadLine());
            double[] vet = new double[n];

            for (int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(Console.ReadLine());
            }

            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma += vet[i];
            }
            double avg = soma / n;

            Console.WriteLine("Média de altura = " + avg.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
