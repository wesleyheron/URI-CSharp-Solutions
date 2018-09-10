using System; 

class URI {

    static void Main(string[] args) { 

        int c = int.Parse(Console.ReadLine());
            int n;
            for (int i = 0; i < c; i++)
            {
                n = int.Parse(Console.ReadLine());
                if (n % 2 == 0)
                    Console.WriteLine(0);
                else
                    Console.WriteLine(1);
            }

    }

}
