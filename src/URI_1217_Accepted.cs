using System; 

class URI {

    static void Main(string[] args) { 

        double total = 0.0;
        
        int soma = 0;
        int qt = int.Parse(Console.ReadLine());
        for (int i = 0; i < qt; i++)
        {
            int kg = 1;
            double v = double.Parse(Console.ReadLine());
            string f = Console.ReadLine();
            total += v;
            for (int j = 0; j < f.Length; j++)
            {
                if (f[j] == 32)
                    kg++;

            }
            soma += kg;
            
            Console.WriteLine("day {0}: {1} kg", i+1, kg);

        }
        Console.WriteLine("{0:0.00} kg by day", (double)soma/qt);
        Console.WriteLine("R$ {0:0.00} by day", total/qt);

    }

}
