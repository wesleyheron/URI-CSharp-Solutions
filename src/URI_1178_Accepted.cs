using System; 

class URI {

    static void Main(string[] args) { 

            decimal valorLido = decimal.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            decimal[] vetor = new decimal[100];
            decimal cont = valorLido;
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = cont;
                cont /= 2;
            }
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("N[{0}] = {1:0.0000}", i, Math.Round(vetor[i],4));
            }

    }

}