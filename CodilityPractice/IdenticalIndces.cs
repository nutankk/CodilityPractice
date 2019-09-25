using System;
namespace CodilityPractice
{
    public class IdenticalIndces
    {
        public IdenticalIndces()
        {
        }
        public  int countPairs(int[] arr)
        {
            int count = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
