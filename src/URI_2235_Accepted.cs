using System; 

class URI {

    static void Main(string[] args) { 

        string[] anos = Console.ReadLine().Split();
        int a = int.Parse(anos[0]);
        int b = int.Parse(anos[1]);
        int c = int.Parse(anos[2]);
        if(a-b==0)
            Console.WriteLine("S");
        else if(a - c == 0)
            Console.WriteLine("S");
        else if (b - c == 0)
            Console.WriteLine("S");
        else if ((a + b) - c == 0)
            Console.WriteLine("S");
        else if ((b + c) - a == 0)
            Console.WriteLine("S");
        else if ((a + c) - b == 0)
            Console.WriteLine("S");
        else
            Console.WriteLine("N");

    }

}
