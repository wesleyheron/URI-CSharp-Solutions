using System; 

class URI {

    static void Main(string[] args) { 

        int qt = int.Parse(Console.ReadLine());
        for (int i = 0; i < qt; i++)
        {
            string[] valor = Console.ReadLine().Split();
            int n = int.Parse(valor[0]);
            int k = int.Parse(valor[1]);
            Console.WriteLine((n % k) + (n / k));
        }

    }

}
