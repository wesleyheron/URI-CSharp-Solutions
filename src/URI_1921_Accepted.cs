using System; 

class URI {

    static void Main(string[] args) { 

        int p = int.Parse(Console.ReadLine());
            long r, aux = 0;
            if(p == 3)
                Console.WriteLine(0);
            else if(p == 4)
                Console.WriteLine(2);
            else
            {
                for (int i = 2; i < p - 1; i++)
                {
                    r = aux + i;
                    aux = r;
                }
                Console.WriteLine(aux);
            }

    }

}
