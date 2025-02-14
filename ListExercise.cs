    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    namespace LIST_AND_DICTIONATY
    {
        public class ListExercise
        {
            //static when use in a method cannot be access a class as an instance reference
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
        
        public static int FindMax(List<int> numbers)
        {
            if(numbers == null ||numbers.Count == 0)
            {
                throw new ArgumentException("The list cannot be null.");
            }
            int max  = numbers[0];

            for(int i = 1 ; i < numbers.Count ; i++)
            {
                if(numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }
       
       public static int FindMin(List<int> numbers)
       {
        if(numbers == null || numbers.Count ==0)
        {
            throw new ArgumentException("The list cannot be null");
        }

        int min = numbers[0];

        for(int i = 1 ; i < numbers.Count ; i++)
        {
            if(numbers[i]< min)
            {
                min = numbers[i];
            }
        }
        return min;

       }
    }
}