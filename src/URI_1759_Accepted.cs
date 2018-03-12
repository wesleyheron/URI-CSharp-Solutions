using System; 

class URI {

    static void Main(string[] args) { 

            long n = long.Parse(Console.ReadLine());
            string ho = "Ho";
            string exclamacao = "Ho!";
            for (int i = 1; i < n; i++)
            {
                Console.Write("{0} ", ho);
            }
            Console.Write(exclamacao.TrimEnd());
            Console.WriteLine();

    }

}