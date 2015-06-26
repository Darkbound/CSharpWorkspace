using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda
{
    class EntryPoint
    {
        static void Main()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 21};

            var newArray = array.Where(n => ((n % 3 == 0) && (n % 7 == 0)))
                                .Select(n => n);

            foreach (var item in newArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
