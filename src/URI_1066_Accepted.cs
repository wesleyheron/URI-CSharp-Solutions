using System; 

class URI {

    static void Main(string[] args) { 

            int[] numeros = new int[5];
            int totalPares = 0, totalNegativo = 0, totalPositivo = 0, totalImpar = 0;
            for(int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                if (numeros[i] % 2 == 0)
                {
                    totalPares++;
                    if(numeros[i] > 0)
                    {
                        totalPositivo++;
                    }
                    else if(numeros[i] < 0)
                    {
                        totalNegativo++;
                    }
                }
                else
                {
                    totalImpar++;
                    if (numeros[i] > 0)
                    {
                        totalPositivo++;
                    }
                    else if(numeros[i] < 0)
                    {
                        totalNegativo++;
                    }
                }                

            }
            Console.WriteLine("{0} valor(es) par(es)", totalPares);
            Console.WriteLine("{0} valor(es) impar(es)", totalImpar);
            Console.WriteLine("{0} valor(es) positivo(s)", totalPositivo);
            Console.WriteLine("{0} valor(es) negativo(s)", totalNegativo);

    }

}