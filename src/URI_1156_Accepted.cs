using System; 

class URI {

    static void Main(string[] args) { 

            double s = 0, n, d = 1, i;            
            

            for (i = 1; i <= 39; i += 2)
            {
                n = (i / d);
                s += n;
                d *= 2;

            }

            Console.WriteLine("{0:0.00}", s);

    }

}