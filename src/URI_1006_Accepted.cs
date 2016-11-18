using System; 

class URI {

    static void Main(string[] args) { 

            double a, b, c, mediaP;

            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            mediaP = ((a * 2.0) + (b * 3.0) + (c * 5.0)) / (2.0 + 3.0 + 5.0);

            Console.WriteLine("MEDIA = {0:0.0}", mediaP);

    }

}