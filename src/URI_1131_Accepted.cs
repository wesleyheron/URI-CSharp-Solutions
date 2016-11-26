using System; 

class URI {

    static void Main(string[] args) { 

            int n;
            int qtdGrenal = 0;
            int vitInter = 0, vitGremio = 0, empates = 0;
            do
            {
                string[] gols = Console.ReadLine().Split();
                int i = Convert.ToInt32(gols[0]);
                int g = Convert.ToInt32(gols[1]);
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                n = Convert.ToInt32(Console.ReadLine());
                qtdGrenal++;
                if(i > g)
                {
                    vitInter++;
                }
                else if(g > i)
                {
                    vitGremio++;
                }
                else
                {
                    empates++;
                }
                
                if (n == 2)
                {
                    Console.WriteLine("{0} grenais", qtdGrenal);
                    Console.WriteLine("Inter:{0}", vitInter);
                    Console.WriteLine("Gremio:{0}", vitGremio);
                    Console.WriteLine("Empates:{0}", empates);
                    if(vitInter > vitGremio)
                        Console.WriteLine("Inter venceu mais");
                    else
                        Console.WriteLine("Gremio venceu mais");                 
                }            

            }
            while (n != 2);

    }

}