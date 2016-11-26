using System; 

class URI {

    static void Main(string[] args) { 

            do
            {
                int soma = 0;
                string[] valores = Console.ReadLine().Split();
                int n = Convert.ToInt32(valores[0]);
                int m = Convert.ToInt32(valores[1]);
                if (n <= 0 || m <= 0)
                    break;

                if (n > m)
                {
                    int aux = n;
                    n = m;
                    m = aux;
                }
                for (int i = n; i <= m; i++)
                {
                    soma += i;
                    Console.Write("{0} ", i);
                }
                Console.WriteLine("Sum={0}", soma);

            } while (true);

    }

}