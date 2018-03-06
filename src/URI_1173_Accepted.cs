using System; 

class URI {

    static void Main(string[] args) { 

            int valorLido = int.Parse(Console.ReadLine());
            int[] n = new int[10];
            int cont = 0;
            int j = 0;
            for (int i = valorLido; cont <= 10-1; i+=i)
            {
                n[j] = i;
                j++;
                cont++;
            }

            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine("N[{0}] = {1}", i, n[i]);
            }

    }

}