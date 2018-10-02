using System; 

class URI {

    static void Main(string[] args) { 

        int n;
        string v;
        int count = 0;
        while ((v = Console.ReadLine()) != null)
        {
            count++;
            int total = 1;
            n = int.Parse(v);
            total += ((n * (n + 1)) / 2);
            if (n == 0)
            {
                Console.WriteLine("Caso {0}: 1 numero", count);
            }
            else
                Console.WriteLine("Caso {0}: {1} numeros", count, total);
            Console.Write("0");

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" {0}", i);
                }
            }            
            Console.WriteLine("\n");
        }

    }

}
