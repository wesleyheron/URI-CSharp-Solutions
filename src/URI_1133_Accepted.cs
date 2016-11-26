using System; 

class URI {

    static void Main(string[] args) { 

        int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            if (x > y)
            {
                int aux = y;
                y = x;
                x = aux;
            }
            for (int i = x + 1; i < y; i++)
            {
                if (i % 5 == 2 || i % 5 == 3)
                {
                    Console.WriteLine(i);
                }
            }

    }

}