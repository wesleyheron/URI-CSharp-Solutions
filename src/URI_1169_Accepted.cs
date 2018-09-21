using System; 

class URI {

    static void Main(string[] args) { 

        int qtdTeste = int.Parse(Console.ReadLine());
        for (int i = 0; i < qtdTeste; i++)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} kg", (Int64)(Math.Pow(2, n) / 12000));
        }

    }

}
