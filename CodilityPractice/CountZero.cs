using System;
using System.Collections.Generic;
namespace CodilityPractice
{
    public class CountZero
    {
        
        public CountZero()
        {
        }
        public void getArray(int N)
        {

            HashSet<int> set = new HashSet<int>();
            
            int rem = N % 2;
            int div = N / 2;

            int[] result = new int[N];
            for (int i = 0; i <div; i++)
            {
                if (!set.Contains(div - i))
                {
                    set.Add(-(div - i));
                }
            }
            if (rem != 0)
            {
                set.Add(0);
            }
            for(int i = 0; i < div; i++)
            {
                if (!set.Contains(div - i))
                {
                    set.Add(div - i);
                }
            }
            set.CopyTo(result);
        }
    }
}
