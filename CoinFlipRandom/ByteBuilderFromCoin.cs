using System;

namespace CoinFlipRandom
{
    public sealed class ByteBuilderFromCoin
    {
        private readonly Coin _coin = new();

        public byte BuildByteUsingCoin(out int headCount, out int tailsCount)
        {
            byte result = 0;
            const byte byteLength = 8;
            headCount = 0;
            tailsCount = 0;
            for (byte bitIndex = 0; bitIndex <= byteLength; bitIndex++)
            {
                bool gotHead = _coin.FlipAndGotHead();
                if (gotHead)
                {
                    result |= 0b00000001;
                    headCount++;
                }
                else
                {
                    tailsCount++;
                }

                bool notTheLastFlip = bitIndex != byteLength;
                if(notTheLastFlip) result = (byte) (result << 1);
            }

            return result;
        }
    }
}