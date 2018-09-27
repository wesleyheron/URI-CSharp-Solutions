using System; 

class URI {

    static void Main(string[] args) { 

        int qt = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < qt; i++)
        {
           
            string[] v = Console.ReadLine().Split();
            string a = v[0];
            string b = v[1];
            

            int c = 0;
            int d = 0;
            int auxA = 0;
            int auxB = 0;

            for (int j = 0; j < 50; j++)
            {
                
                if (a.Length == auxA)
                    c = 1;
                if (b.Length == auxB)
                    d = 1;
                if (c == 1 && d == 1)
                    break;
                if(c == 0)
                    Console.Write("{0}", a[j]);
                if (d == 0)
                    Console.Write("{0}", b[j]);
                auxA++;
                auxB++;
            }
            Console.WriteLine();
            

        }

    }

}
