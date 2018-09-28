using System; 

class URI {

    static void Main(string[] args) { 

        while (true)
        {
            string[] v = Console.ReadLine().Split();
            int l = int.Parse(v[0]);
            int r = int.Parse(v[1]);
            if (l == 0 && r == 0)
                break;
            Console.WriteLine("{0}", (l + r));
        }

    }

}
