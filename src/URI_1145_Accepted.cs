using System; 

class URI {

    static void Main(string[] args) { 

            string[] valores = Console.ReadLine().Split();
            int x = Convert.ToInt32(valores[0]);
            int y = Convert.ToInt32(valores[1]);
            int n = 0;
            for (int i = 1; i <= y; i++)
            {
                n++;
                if(n == x)
                    Console.Write("{0}", i);
                else
                    Console.Write("{0} ", i);
                if (n == x)
                {
                    n = 0;
                    Console.WriteLine();
                }
            }

    }

}