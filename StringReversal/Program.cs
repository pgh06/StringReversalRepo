using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReversal
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomString = "234242heytest123";

            char[] orderedArray = randomString.ToCharArray();

            var left = 0;
            var right = orderedArray.Length - 1;

            for (int i = 0; left < right; left++, right--)
            {
                var temp = orderedArray[left];
                orderedArray[left] = orderedArray[right];
                orderedArray[right] = temp;
            }

            Console.WriteLine(orderedArray);
            Console.ReadLine();
        }
    }
}
