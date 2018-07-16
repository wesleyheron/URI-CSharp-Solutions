using System; 

class URI {

    static void Main(string[] args) { 

            string[] valores = Console.ReadLine().Split();
            int a = int.Parse(valores[0]);
            int b = int.Parse(valores[1]);
            int c = int.Parse(valores[2]);

            
            if (a > b && b <= c)
                Console.WriteLine(":)");
            else if (a < b && b >= c)
                Console.WriteLine(":(");
            else if (b > a && c > b && (b - a > c - b))
                Console.WriteLine(":(");
            else if (b > a && c > b && ((b - a) <= (c - b)))
                Console.WriteLine(":)");
            else if (b < a && c < b && (a - b) > (b - c))
                Console.WriteLine(":)");
            else if (b < a && c < b && (a - b <= b - c))
                Console.WriteLine(":(");
            else if (a == b)
            {
                if(b < c)
                    Console.WriteLine(":)");
                else
                    Console.WriteLine(":(");
            }

    }

}
