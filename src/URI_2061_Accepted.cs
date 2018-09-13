using System; 

class URI {

    static void Main(string[] args) { 

        string[] v = Console.ReadLine().Split();
            int n = int.Parse(v[0]);
            int m = int.Parse(v[1]);
            int cont = n;
            for (int i = 0; i < m; i++)
            {
                string a = Console.ReadLine();
                if (a == "fechou")
                    cont++;
                else
                    cont--;
            }
            Console.WriteLine(cont);

    }

}
