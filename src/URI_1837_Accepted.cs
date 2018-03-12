using System; 

class URI {

    static void Main(string[] args) { 

            string[] valores = Console.ReadLine().Split();
            int a = int.Parse(valores[0]);
            int b = int.Parse(valores[1]);
            int q, r;

            q = a / b;
            r = a % b;
            for (r = 0; r < Math.Abs(b); r++)
            {
                if((a - r) % b == 0)
                {
                    q = (a - r) / b;
                    break;
                }
            }

            Console.WriteLine("{0} {1}", q, r);

    }

}