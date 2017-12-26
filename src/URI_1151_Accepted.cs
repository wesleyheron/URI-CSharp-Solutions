using System; 

class URI {

    static void Main(string[] args) { 

            int n = Convert.ToInt32(Console.ReadLine());
            int[] fibn = new int[46];

            fibn[0] = 0;
            fibn[1] = 1;

            Console.Write("{0} {1} ", fibn[0], fibn[1]);

            for (int i= 2; i < n; i++)
            {

                fibn[i] = fibn[i - 1] + fibn[i - 2];
                if(i == (n - 1))
                {
                    Console.Write("{0}", fibn[i]);
                }
                else
                {
                    Console.Write("{0} ", fibn[i]);
                }

            }
            Console.WriteLine();

    }

}