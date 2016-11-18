using System; 

class URI {

    static void Main(string[] args) { 

            double x1, y1, x2, y2, distancia;
            string[] p1 = Console.ReadLine().Split();

            x1 = Convert.ToDouble(p1[0]);
            y1 = Convert.ToDouble(p1[1]);

            string[] p2 = Console.ReadLine().Split();

            x2 = Convert.ToDouble(p2[0]);
            y2 = Convert.ToDouble(p2[1]);

            distancia = Math.Sqrt(((x2 - x1) * (x2 - x1)) + (y2 - y1) * (y2 - y1));

            Console.WriteLine(distancia.ToString("0.0000"));

    }

}