using System; 

class URI {

    static void Main(string[] args) { 

            double[] numeros = new double[6];
            int totalPositivos = 0;
            double media = 0, soma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = Convert.ToDouble(Console.ReadLine());
                if (numeros[i] > 0)
                {
                    totalPositivos++;
                    soma += numeros[i];
                }
                media = (soma) / totalPositivos;
            }
            Console.WriteLine("{0} valores positivos", totalPositivos);
            Console.WriteLine("{0:0.0}", media);

    }

}