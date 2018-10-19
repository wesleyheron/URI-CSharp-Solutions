using System; 

class URI {

    static void Main(string[] args) { 

        char operacao = char.Parse(Console.ReadLine());
        int p = 0;
        int q = 4;

        double[,] matriz = new double[12, 12];
        double soma = 0, media = 0;

        for (int i = 0; i < matriz.GetLength(0); i++)
        {

            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i, j] = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

            }

        }        

        for (int k = 1; k <= 10; k++)
        {
            if(k <= 5)
            {
                for (int j = 0; j <= p; j++)
                {
                    soma += matriz[k, j];
                }
                p++;
            }
            else if(k >= 6)
            {
                for (int j = 0; j <= q; j++)
                {
                    soma += matriz[k, j];
                }                    
                q--;
            }
            
        }
        switch (operacao)
        {
            case 'S':
                Console.WriteLine("{0:0.0}", soma);
                break;
            case 'M':
                Console.WriteLine("{0:0.0}", (media = soma / 30.0));
                break;
            default:
                break;
        }

    }

}
