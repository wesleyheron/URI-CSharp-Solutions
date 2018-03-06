using System; 

class URI {

    static void Main(string[] args) { 

            int t = int.Parse(Console.ReadLine());
            int[] n = new int[1000];
            int cont = 0;
            for (int i = 0; i < n.Length; i++)
            {
                n[i] = cont;
                cont++;
                if (cont == t)
                    cont = 0;
            }

            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine("N[{0}] = {1}", i, n[i]);
            }

    }

}