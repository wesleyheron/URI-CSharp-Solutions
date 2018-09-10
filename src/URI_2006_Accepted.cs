using System; 

class URI {

    static void Main(string[] args) { 

        int t = int.Parse(Console.ReadLine());
            string[] r = Console.ReadLine().Split();
            int cont = 0;

            for (int i = 0; i < r.Length; i++)
            {
                if (t == int.Parse(r[i]))
                    cont++;

            }
            Console.WriteLine(cont);

    }

}
