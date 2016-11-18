using System; 

class URI {

    static void Main(string[] args) { 

            double a, b, c;
            double pi = 3.14159;
            string[] num = Console.ReadLine().Split();

            a = Convert.ToDouble(num[0]);
            b = Convert.ToDouble(num[1]);
            c = Convert.ToDouble(num[2]);

            Console.WriteLine("TRIANGULO: {0:0.000}", ((a * c) / 2));
            Console.WriteLine("CIRCULO: {0:0.000}", (pi * (c * c)));
            Console.WriteLine("TRAPEZIO: {0:0.000}", ((a + b) * c) / 2);
            Console.WriteLine("QUADRADO: {0:0.000}", (b * b));
            Console.WriteLine("RETANGULO: {0:0.000}", (a * b));

    }

}