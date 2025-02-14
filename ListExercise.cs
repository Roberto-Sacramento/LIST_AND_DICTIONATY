using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIST_AND_DICTIONATY
{
    public class ListExercise
    {
        public static int SumLists(List<int> numbers)
        {
             if (numbers == null)
        {
            throw new ArgumentNullException("The list cannot be null.");
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum;
        }
    }
}