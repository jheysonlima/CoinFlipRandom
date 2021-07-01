using System;
using System.Collections.Generic;
using System.Linq;

namespace CoinFlipRandom
{
    internal static class PromptPresenter
    {
        internal static int AskTotalRunCount()
        {
            Console.WriteLine("Digite quantos bytes deseja gerar:");
            return int.Parse(Console.ReadLine());
        }

        internal static void ShowHeadAndTailsCount(int headCount, int tailsCount)
        {
            Console.WriteLine($"Quantidade de jogadas cara: {headCount}");
            Console.WriteLine($"Quantidade de jogadas coroa: {tailsCount}");
            Console.WriteLine($"Quantidade total de cara ou coroa: {headCount + tailsCount}");
        }

        internal static void ShowResultCountByByte(Dictionary<byte, int> results)
        {
            int totalResultCount = results.Sum(pair => pair.Value);

            foreach (var result in results.OrderBy(pair => pair.Key))
            {
                Console.WriteLine($"Quantidade de resultados para o valor {result.Key}: {result.Value} Frequencia: {GetResultRepetitionPercentage(result.Value, totalResultCount)}%");
            }

            Console.WriteLine($"Quantidade de resultados gerados: {totalResultCount}");
        }

        internal static float GetResultRepetitionPercentage(int resultCount, int totalCount)
        {
            return ((float)resultCount / totalCount) * 100;
        }
    }
}