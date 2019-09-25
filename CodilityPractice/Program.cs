using System;

namespace CodilityPractice
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*int[] arr = { 3,5,6,3,3,5 };
            IdenticalIndces ic = new IdenticalIndces();
            Console.WriteLine(ic.countPairs(arr));
            stringmap<string> sc = new stringmap<string>();
            sc.AddElement("1", "A");
            sc.AddElement("2", "B");
            sc.AddElement("3", "C");
            Console.WriteLine(sc.count.ToString());
            Console.WriteLine(sc.RemoveElement("2"));
            Console.WriteLine(sc.count.ToString());
            Console.WriteLine(sc.AddElement("5","D"));
            Console.WriteLine(sc.GetValue("1"));*/
            int[] a = { };
            NiceArray nc = new NiceArray();
            Console.WriteLine(nc.isNice(a));
        }
    }
}
