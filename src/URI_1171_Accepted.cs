using System;
using System.Linq;

class URI {

    static void Main(string[] args) { 

        int n = int.Parse(Console.ReadLine());
        int[] first = new int[n];
        for (int i = 0; i < n; i++)
        {
            int v = int.Parse(Console.ReadLine());
            first[i] = v;
        }
        var groups = first.GroupBy(c => c).OrderBy(c => c.Key);
        foreach (var item in groups)
        {
            Console.WriteLine("{0} aparece {1} vez(es)", item.Key, item.Count());
        }

    }

}
