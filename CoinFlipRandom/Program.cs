using System;

namespace CoinFlipRandom
{
    internal class Program
    {
        private static void Main()
        {
            int runCount = PromptPresenter.AskTotalRunCount();
            ResultCollector resultCollector = new ResultCollector();
            resultCollector.AddRuns(runCount);
            Console.WriteLine();
            PromptPresenter.ShowHeadAndTailsCount(resultCollector.HeadCount, resultCollector.TailsCount);
            Console.WriteLine();
            PromptPresenter.ShowResultCountByByte(resultCollector.RepetitionsByValue);
        }
    }
}