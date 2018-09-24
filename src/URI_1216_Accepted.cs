using System; 

class URI {

    static void Main(string[] args) { 

        string n;
        double total = 0;
        int qt = 0;
        while ((n = Console.ReadLine()) != null)
        {
            int v = int.Parse(Console.ReadLine());
            if (v == -1)
                break;
            total += v;
            qt++;

        }
        Console.WriteLine("{0:0.0}", total / qt);

    }

}
