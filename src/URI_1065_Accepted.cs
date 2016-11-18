using System; 

class URI {

    static void Main(string[] args) { 

            int[] numeros = new int[5];
            int totalPares = 0;
            for(int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                if(numeros[i] % 2 == 0)
                {
                    totalPares++; 
                }
            }
            Console.WriteLine("{0} valores pares", totalPares);

    }

}