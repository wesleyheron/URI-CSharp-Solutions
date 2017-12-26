using System; 

class URI {

            string[] valores;

            int a;
            int n;

            valores = Console.ReadLine().Split();

            a = Convert.ToInt32(valores[0]);
            n = Convert.ToInt32(valores[1]);

            while (n <= 0)
            {
                for (int i = Array.IndexOf(valores, n); i < valores.Length -1; i++)
                {
                    n = Convert.ToInt32(valores[i + 1]);
                }
                
            }                     

            Console.WriteLine((a + (a + n - 1)) * n / 2);

}