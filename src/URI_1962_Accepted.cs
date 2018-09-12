using System; 

class URI {

    static void Main(string[] args) { 

        long qt = long.Parse(Console.ReadLine());
            long t;
            for (long i = 0; i < qt; i++)
            {
                t = long.Parse(Console.ReadLine());
                long s = 2015 - t;
                if(s < 0)
                    Console.WriteLine("{0} A.C.", t - 2015 + 1);
                else if(s == 0)
                    Console.WriteLine("{0} A.C.", s + 1);
                else
                    Console.WriteLine("{0} D.C.", 2015 - t);
            }

    }

}
