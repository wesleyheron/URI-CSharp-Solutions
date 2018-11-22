using System; 

class URI {

    static void Main(string[] args) { 

        int qC = int.Parse(Console.ReadLine());
        int s1, b1, a1, s2, b2, a2;
        int somaS1 = 0;
        int somaB1 = 0;
        int somaA1 = 0;
        int somaS2 = 0;
        int somaB2 = 0;
        int somaA2 = 0;
        for (int i = 0; i < qC; i++)
        {
            string nomeCompetidor = Console.ReadLine();
            string[] jogada1 = Console.ReadLine().Split();
            string[] jogada2 = Console.ReadLine().Split();

            s1 = int.Parse(jogada1[0]);
            b1 = int.Parse(jogada1[1]);
            a1 = int.Parse(jogada1[2]);

            s2 = int.Parse(jogada2[0]);
            b2 = int.Parse(jogada2[1]);
            a2 = int.Parse(jogada2[2]);

            somaS1 += s1;
            somaB1 += b1;
            somaA1 += a1;

            somaS2 += s2;
            somaB2 += b2;
            somaA2 += a2;

        }
        Console.WriteLine("Pontos de Saque: {0:0.00} %.", ((double)somaS2 / somaS1) * 100.0);
        Console.WriteLine("Pontos de Bloqueio: {0:0.00} %.", ((double)somaB2 / somaB1) * 100);
        Console.WriteLine("Pontos de Ataque: {0:0.00} %.", ((double)somaA2 / somaA1) * 100);

    }

}
