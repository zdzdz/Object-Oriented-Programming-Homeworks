using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _64BitArray
{
    class TestArray
    {
        static void Main()
        {
            BitArray64 arr = new BitArray64(25u);
            BitArray64 arr2 = new BitArray64(16u);

            Console.WriteLine(arr);
            arr[4] = 0;
            Console.WriteLine(arr);

            Console.WriteLine(arr == arr2);
            Console.WriteLine(arr.Equals(arr));
            Console.WriteLine(arr != arr2);
        }
    }
}
