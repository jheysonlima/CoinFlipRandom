using System;

namespace CoinFlipRandom
{
    public sealed class Coin
    {
        private readonly Random _random = new();

        public bool FlipAndGotHead()
        {
            return _random.Next(0, 2) == 0;
        }
    }
}