using System; 

class URI {

    static void Main(string[] args) { 

            long numeroDeTestes, qtdIn = 0, qtdOut = 0;
            numeroDeTestes = Convert.ToInt64(Console.ReadLine());
            for(long i = 0; i < numeroDeTestes; i++)
            {
                long numeros = Convert.ToInt64(Console.ReadLine());
                if (numeros >= 10 && numeros <= 20)
                {
                    qtdIn++;
                }
                else
                {
                    qtdOut++;
                }
            }
            Console.WriteLine("{0} in", qtdIn);
            Console.WriteLine("{0} out", qtdOut);
    }

}