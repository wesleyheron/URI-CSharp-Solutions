using System;
using System.Linq;

class URI
{

    static void Main(string[] args)
    {
        int qt = int.Parse(Console.ReadLine());        
        
        for (int i = 0; i < qt; i++)
        {
            string[] v1 = Console.ReadLine().Split();
            int[] arr = new int[v1.Length - 1];

            for (int j = 1; j < v1.Length; j++)
            {
                arr[j - 1] = int.Parse(v1[j]);
            }
            int halfIndex = arr.Count() / 2;

            int first = int.Parse(v1[0]);            
            double med;

            Array.Sort(arr);
            if (first % 2 == 0)
            {
                int a = arr.ElementAt(halfIndex);
                int b = arr.ElementAt((halfIndex - 1));
                med = Math.Max(a, b);
            }
            else
                med = arr.ElementAt(halfIndex);

            Console.WriteLine("Case {0}: {1}", i + 1, med);


        }


    }

}
