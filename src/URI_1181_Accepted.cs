using System; 

class URI {

    static void Main(string[] args) { 

            int linha = int.Parse(Console.ReadLine());
            char operacao = char.Parse(Console.ReadLine());

            double[,] matriz = new double[12, 12];
            double soma = 0, media = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
                    if (i == linha)
                    {
                        soma += matriz[i, j];
                        media = soma / 12;
                    }
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