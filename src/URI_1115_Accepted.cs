using System; 

class URI {

    static void Main(string[] args) { 

            do
            {
                string[] coordenadas = Console.ReadLine().Split();
                int x = Convert.ToInt32(coordenadas[0]);
                int y = Convert.ToInt32(coordenadas[1]);

                if(x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if(x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if(x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else if(x > 0 && y < 0)
                {
                    Console.WriteLine("quarto");
                }
                else if(x == 0 || y == 0)
                {
                    break;
                }

            }
            while (true);

    }

}