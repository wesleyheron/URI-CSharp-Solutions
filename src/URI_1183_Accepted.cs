using System; 

class URI {

    static void Main(string[] args) { 

            char operacao = char.Parse(Console.ReadLine());
            int contDiagonal = 1;

            double[,] matriz = new double[12, 12];
            double soma = 0, media = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
                    
                }

            }
            for (int k = 0; k < 12; k++)
            {
                for (int p = contDiagonal; p < 12; p++)
                {
                    soma += matriz[k, p];
                    media = soma / 66;
                    
                }
                contDiagonal++;
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