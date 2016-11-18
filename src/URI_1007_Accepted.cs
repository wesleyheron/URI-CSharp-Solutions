using System; 

class URI {

    static void Main(string[] args) { 

            int a, b, c, d, diferenca;

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());

            diferenca = (a * b - c * d);

            Console.WriteLine("DIFERENCA = {0}", diferenca);

    }

}