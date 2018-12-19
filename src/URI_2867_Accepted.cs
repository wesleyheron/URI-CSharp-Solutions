using System;
using System.Linq;

class URI {

    static void Main(string[] args) { 

        int qt = int.Parse(Console.ReadLine());
        for (int i = 0; i < qt; i++)
        {
            string[] valor = Console.ReadLine().Split();
            int n = int.Parse(valor[0]);
            int m = int.Parse(valor[1]);
            var res = Math.Pow(n, m);
            Console.WriteLine(res.ToString("#").Count());
            
        }

    }

}
