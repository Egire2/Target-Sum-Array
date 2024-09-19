using System;
using System.Collections.Generic;

namespace Task
{
    class ByteStreamReverse
    {
        public byte[] ReverseArrayByte(byte[] bits)
        {
            int n = bits.Length;
            int segmentSize = 8; 
            int segmentCount = n / segmentSize;

            byte[] reversedBits = new byte[n];

            for (int i = 0; i < segmentCount; i++)
            {
                int currentSegmentStart = i * segmentSize;
                int reverseSegmentStart = (segmentCount - 1 - i) * segmentSize;
                for (int j = 0; j < segmentSize; j++)
                {
                    reversedBits[reverseSegmentStart + j] = bits[currentSegmentStart + j];
                }
            }
            return reversedBits;
        }
    }
}
