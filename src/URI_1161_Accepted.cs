using System; 

class URI {

    static void Main(string[] args) { 

            string linha;
            while ((linha = Console.ReadLine()) != null)
            {
                string[] valores = linha.Split();

                long m, n, i, j;
                m = long.Parse(valores[0]);
                
                for (i = 1; m > 1; m--)
                {
                    i *= m;
                }

                n = long.Parse(valores[1]);

                for (j = 1; n > 1; n--)
                {
                    j *= n;
                }

                long somaFatorial = i + j;
                Console.WriteLine("{0}", somaFatorial);
            }

    }

}