using System; 

class URI {

    static void Main(string[] args) { 

        char operacao = char.Parse(Console.ReadLine());
        int contDiagonal = 0;

        double[,] matriz = new double[12, 12];
        double soma = 0, media = 0;

        for (int i = 0; i < matriz.GetLength(0); i++)
        {

            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i, j] = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

            }

        }        

        for (int k = 0; k < 5; k++)
        {
            for (int j = k + 1; j < 11 - k; j++)
            {
                soma += matriz[k, j];                
                contDiagonal++;
                media = soma / contDiagonal;
            }
        }
        switch (operacao)
        {
            case 'S':
                Console.WriteLine("{0:0.0}", soma);
                break;
            case 'M':
                Console.WriteLine("{0:0.0}", media);
                break;
            default:
                break;
        }

    }

}
