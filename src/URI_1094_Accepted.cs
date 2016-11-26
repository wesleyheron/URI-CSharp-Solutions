using System; 

class URI {

    static void Main(string[] args) { 

            int n = Convert.ToInt32(Console.ReadLine());
            int somaCobaias = 0, totalCoelhos = 0, totalRatos = 0, totalSapos = 0;
            for(int i = 0; i < n; i++)
            {
                string[] cobaia = Console.ReadLine().Split();
                int quantia = Convert.ToInt32(cobaia[0]);
                char tipo = Convert.ToChar(cobaia[1]);
                somaCobaias += quantia;
                switch (tipo)
                {
                    case 'C':
                        totalCoelhos += quantia;
                        break;
                    case 'R':
                        totalRatos += quantia;
                        break;
                    case 'S':
                        totalSapos += quantia;
                        break;
                }
            }
            Console.WriteLine("Total: {0} cobaias", somaCobaias);
            Console.WriteLine("Total de coelhos: {0}", totalCoelhos);
            Console.WriteLine("Total de ratos: {0}", totalRatos);
            Console.WriteLine("Total de sapos: {0}", totalSapos);
            Console.WriteLine("Percentual de coelhos: {0:0.00} %", (float)(totalCoelhos * 100) / somaCobaias);
            Console.WriteLine("Percentual de ratos: {0:0.00} %", (float)(totalRatos * 100) / somaCobaias);
            Console.WriteLine("Percentual de sapos: {0:0.00} %", (float)(totalSapos * 100) / somaCobaias);

    }

}