using System; 

class URI {

    static void Main(string[] args) { 

            do
            {
                string[] valores = Console.ReadLine().Split();
                int n = Convert.ToInt32(valores[0]);
                int m = Convert.ToInt32(valores[1]);
                if (n == m)
                    break;

                if (n > m)
                {
                    Console.WriteLine("Decrescente");
                }
                else
                {
                    Console.WriteLine("Crescente");
                }                

            } while (true);

    }

}