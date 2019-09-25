using System.Linq;
namespace CodilityPractice
{
    public class NiceArray
    {
        public NiceArray()
        {

        }
        public bool isNice(int[] a)
        {
            if (a.Length == 0)
            {
                return false;
            }
            else { 
               int temp = a[0];
                for (int i = 1; i < a.Length; i++)
                {
                    if ((a.Contains(temp + 1)) || (a.Contains(temp - 1)))
                    {
                        temp = a[i];
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }
            
        }
    }
}
