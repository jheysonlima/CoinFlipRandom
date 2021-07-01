using System.Collections.Generic;

namespace CoinFlipRandom
{
    public sealed class ResultCollector
    {
        public Dictionary<byte, int> RepetitionsByValue { get; } = new();
        public int HeadCount { get; private set; }
        public int TailsCount { get; private set; }

        public void AddRuns(int count)
        {
            ByteBuilderFromCoin byteBuilder = new();

            for (int builtCount = 0; builtCount < count; builtCount++)
            {
                byte builtByte = byteBuilder.BuildByteUsingCoin(out int headCount, out int tailsCount);
                CountHeadsAndTails(headCount, tailsCount);
                CountRepetitions(builtByte);
            }
        }

        private void CountHeadsAndTails(int headCount, int tailsCount)
        {
            HeadCount += headCount;
            TailsCount += tailsCount;
        }

        private void CountRepetitions(byte builtByte)
        {
            if (RepetitionsByValue.ContainsKey(builtByte)) RepetitionsByValue[builtByte]++;
            else RepetitionsByValue.Add(builtByte, 1);
        }
    }
}