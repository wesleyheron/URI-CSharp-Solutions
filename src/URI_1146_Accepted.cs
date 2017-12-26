using System; 

class URI {

    static void Main(string[] args) { 

            while (true)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int i;
                if (n == 0)
                {
                    break;
                }
                else
                {
                    for (i = 1; i < n; i++)
                    {
                        Console.Write("{0} ", i);
                    }
                    Console.WriteLine("{0}", n);
                }                
            }

    }

}