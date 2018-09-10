using System; 

class URI {

    static void Main(string[] args) { 

         string[] v = Console.ReadLine().Split();
            double a = double.Parse(v[0]);
            double b = double.Parse(v[1]);

            double res = (b - a) / a * 100;
            Console.WriteLine("{0:0.00}%", res);

    }

}
