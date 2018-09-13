using System; 

class URI {

    static void Main(string[] args) { 

        string[] v = Console.ReadLine().Split();
            float h = float.Parse(v[0]);
            float t = float.Parse(v[1]);

            float val = (h / t ) ;

            Console.WriteLine("{0:0.00}", Math.Round(val, 2));

    }

}
