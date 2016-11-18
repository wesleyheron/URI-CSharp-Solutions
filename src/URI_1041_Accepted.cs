using System; 

class URI {

    static void Main(string[] args) { 

            double x, y;
            string[] valor = Console.ReadLine().Split();

            x = Convert.ToDouble(valor[0]);
            y = Convert.ToDouble(valor[1]);

            if((x > 0) && (y > 0))
            {
                Console.WriteLine("Q1");
            }
            else if((y > 0) && (x < 0))
            {
                Console.WriteLine("Q2");
            }
            else if((x < 0) && (y < 0))
            {
                Console.WriteLine("Q3");
            }
            else if((y < 0) && (x > 0))
            {
                Console.WriteLine("Q4");
            }
            else if((x == 0) && (y == 0))
            {
                Console.WriteLine("Origem");
            }
            else if((x > 0) || (x < 0))
            {
                Console.WriteLine("Eixo X");
            }
            else if ((y > 0) || (y <= 0))
            {
                Console.WriteLine("Eixo Y");
            }

    }

}