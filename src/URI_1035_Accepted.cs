using System; 

class URI {

    static void Main(string[] args) { 

            int a, b, c, d;
            string[] valor = Console.ReadLine().Split();
            a = Convert.ToInt32(valor[0]);
            b = Convert.ToInt32(valor[1]);
            c = Convert.ToInt32(valor[2]);
            d = Convert.ToInt32(valor[3]);

            if((b > c) && (d > a) && ((c + d) > (a + b)))
            {
                if(c >= 0 && d >= 0)
                {
                    if(a % 2 == 0)
                    {
                        Console.WriteLine("Valores aceitos");
                    }
                }
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }

    }

}