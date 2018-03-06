using System; 

class URI {

    static void Main(string[] args) { 

            int qtdTestes = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < qtdTestes; i++)
            {
                string[] valorLido = Console.ReadLine().Split();
                int x, y;
                x = int.Parse(valorLido[0]);
                y = int.Parse(valorLido[1]);
                int r = (((3 * x) * (3 * x)) + (y * y));
                int b = 2 * (x * x) + ((5 * y) * (5 * y));
                int c = ((-100 * x) + (y * y * y));

                if(r > b && r > c)
                    Console.WriteLine("Rafael ganhou");
                else if (b > r && b > c)
                    Console.WriteLine("Beto ganhou");
                else if (c > r && c > b)
                    Console.WriteLine("Carlos ganhou");
            }

    }

}