using System;
using System.Numerics;

class URI {

    static void Main(string[] args) { 

        BigInteger n;
        do
        {
            n = BigInteger.Parse(Console.ReadLine());
            if (n == -1)
                break;
            if(n == 0)
                Console.WriteLine(0);
            else
                Console.WriteLine("{0}", n - 1);
        } while (true);

    }

}
