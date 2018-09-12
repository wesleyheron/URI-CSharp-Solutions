using System; 

class URI {

    static void Main(string[] args) { 

        double v, d, a, alt;
            double pi = 3.14;
            string vol, di;      

            while ((vol = Console.ReadLine()) != null && (di = Console.ReadLine()) != null)
            {
                v = double.Parse(vol);
                d = double.Parse(di);
                a = pi * Math.Pow(d / 2, 2);
                alt = v / a;
                Console.WriteLine("ALTURA = {0:0.00}", alt);
                Console.WriteLine("AREA = {0:0.00}", Math.Round(a, 2));

            }

    }

}
