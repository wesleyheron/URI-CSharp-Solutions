using System; 

class URI {

    static void Main(string[] args) { 

            int n = Convert.ToInt32(Console.ReadLine());
            int j;
            for (int i = 1; i <= n; i++)
            {
                int x = Convert.ToInt32(Console.ReadLine());

                for (j = 2; j <= (x - 1); j++)
                {
                    if (x % j == 0)
                    {
                        Console.WriteLine("{0} nao eh primo", x);
                        break;
                    }
                }
                if(x == 1 || x == 2)
                {
                    Console.WriteLine("{0} eh primo", x);
                }
                else if (j == x)
                {
                    Console.WriteLine("{0} eh primo", x);
                }
            }

    }

}