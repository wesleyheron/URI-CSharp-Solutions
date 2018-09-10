using System; 

class URI {

    static void Main(string[] args) { 

        int qt = int.Parse(Console.ReadLine());
            decimal nmaior = 0;
            int matricula = 0;
            for (int i = 0; i < qt; i++)
            {
                string[] v = Console.ReadLine().Split();
                if (decimal.Parse(v[1]) > nmaior)
                {
                    nmaior = decimal.Parse(v[1]);
                    matricula = int.Parse(v[0]);
                }                

            }
            if(nmaior < 8)
                Console.WriteLine("Minimum note not reached");
            else
                Console.WriteLine(matricula); 

    }

}
