using System; 

class URI {

    static void Main(string[] args) { 

            double[] numeros = new double[6];
            int totalPositivos = 0; 
            for(int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = Convert.ToDouble(Console.ReadLine());
                if(numeros[i] > 0)
                {
                    totalPositivos++;
                }
            }
            Console.WriteLine("{0} valores positivos", totalPositivos);

    }

}