using System; 

class URI {

    static void Main(string[] args) { 

        string n;
        while ((n = Console.ReadLine()) != null)
        {
            int p = int.Parse(n);
            int votosContra = 0;
            int votosFavor = 0;
            string[] votos = Console.ReadLine().Split();
            for (int i = 0; i < p; i++)
            {
                if (int.Parse(votos[i]) == 0)
                    votosContra++;
                else
                    votosFavor++;
            }
            if (votosFavor >= votosContra + votosContra)
                Console.WriteLine("impeachment");
            else
                Console.WriteLine("acusacao arquivada");
        }

    }

}
