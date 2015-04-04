using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;

namespace _64BitArray
{
    public class BitArray64 : IEnumerable<int>
    {
        private ulong bitValue;

        public BitArray64()
        {}

        public BitArray64(ulong bitValue)
        {
            this.BitValue = bitValue;
        }

        public ulong BitValue { get; set; }

        // Indexer

        public int this[int index]
        {
            get
            {
                if (index < 0 || index > 63)
                {
                    throw new IndexOutOfRangeException("Invalid position.");
                }
                else
                {
                    return (this.bitValue & ((ulong)1 << index)) == 0 ? 0 : 1;
                }
                
            }
            set
            {
                if (index < 0 || index > 63)
                {
                    throw new IndexOutOfRangeException("Invalid position.");
                }
                if (value != 0 && value != 1)
                {
                    throw  new ArgumentOutOfRangeException("Invalid bit value.");
                }

                this.bitValue = (this.bitValue & ~((ulong)1 << index) | ((ulong)value << index));
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < 64; i++)
            {
                yield return this[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override bool Equals(object obj)
        {
            BitArray64 bitArray = obj as BitArray64;

            if (bitArray == null)
            {
                return false;
            }
            else
            {
                return this.BitValue.Equals(bitArray.BitValue);
            }
        }

        public override int GetHashCode()
        {
            return this.BitValue.GetHashCode();
        }

        public static bool operator ==(BitArray64 firstArray, BitArray64 secondArray)
        {
            return BitArray64.Equals(firstArray, secondArray);
        }

        public static bool operator !=(BitArray64 firstArray, BitArray64 secondArray)
        {
            return !(BitArray64.Equals(firstArray, secondArray));
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int pos = 0; pos < 64; pos++)
            {
                sb.Insert(0, ((this.BitValue >> pos) & 1));
            }
            return sb.ToString();
        }

        public int CompareTo(object obj)
        {
            BitArray64 bitArray = obj as BitArray64;
            return this.CompareTo(bitArray.BitValue);
        }
    }
}
