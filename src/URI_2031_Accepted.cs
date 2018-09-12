using System; 

class URI {

    static void Main(string[] args) { 

        int qt = int.Parse(Console.ReadLine());

            for (int i = 0; i < qt; i++)
            {
                string j1 = Console.ReadLine();
                string j2 = Console.ReadLine();
                if (j1 == "ataque" && j2 == "ataque")
                    Console.WriteLine("Aniquilacao mutua");
                else if (j1 == "papel" && j2 == "papel")
                    Console.WriteLine("Ambos venceram");
                else if (j1 == "pedra" && j2 == "pedra")
                    Console.WriteLine("Sem ganhador");

                else if (j1 == "ataque" && j2 == "pedra")
                    Console.WriteLine("Jogador 1 venceu");
                else if (j2 == "ataque" && j1 == "pedra")
                    Console.WriteLine("Jogador 2 venceu");
                else if (j1 == "ataque" && j2 == "papel")
                    Console.WriteLine("Jogador 1 venceu");
                else if (j2 == "ataque" && j1 == "papel")
                    Console.WriteLine("Jogador 2 venceu");

                else if (j1 == "pedra" && j2 == "papel")
                    Console.WriteLine("Jogador 1 venceu");
                else if (j2 == "pedra" && j1 == "papel")
                    Console.WriteLine("Jogador 2 venceu");
            }

    }

}
