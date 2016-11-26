using System; 

class URI {

    static void Main(string[] args) { 

            int n = Convert.ToInt32(Console.ReadLine());
            double[] valores = new double[3];
            for (int i = 0; i < n; i++)
            {
                string[] media = Console.ReadLine().Split();
                double a = Convert.ToDouble(media[0]);
                double b = Convert.ToDouble(media[1]);
                double c = Convert.ToDouble(media[2]);
                double resultado = (a * 2 + b * 3 + c * 5) / (2.0 + 3.0 + 5.0);
                Console.WriteLine("{0:0.0}", resultado);
            }

    }

}