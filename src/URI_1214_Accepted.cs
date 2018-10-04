using System; 

class URI {

    static void Main(string[] args) { 

        int qtdTeste = int.Parse(Console.ReadLine());
        int soma = 0;
        int m, p = 0;
        for (int i = 0; i < qtdTeste; i++)
        {
            soma = 0;
            p = 0;
            float ac;
            string[] valores = Console.ReadLine().Split();
            int qtdNotas = int.Parse(valores[0]);

            for (int j = 1; j <= qtdNotas; j++)
            {
                soma += int.Parse(valores[j]);
            }
            m = soma / qtdNotas;
            for (int k = 1; k <= qtdNotas; k++)
            {
                if (m < int.Parse(valores[k]))
                    p++;
            }
            ac = (float)(p * 100.00) / qtdNotas;
            Console.WriteLine(Math.Round(ac, 3).ToString("#.000") +"%");

        }

    }

}
