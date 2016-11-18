using System; 

class URI {

    static void Main(string[] args) { 

            double a, b, c;
            string[] valor = Console.ReadLine().Split();
            a = Convert.ToDouble(valor[0]);
            b = Convert.ToDouble(valor[1]);
            c = Convert.ToDouble(valor[2]);

            if((a + b > c) && (a + c > b) && (b + c > a))
            {
                Console.WriteLine("Perimetro = {0:0.0}", a + b + c);
            }
            else
            {
                Console.WriteLine("Area = {0:0.0}", ((a+b)*c)/2);
            }

    }

}