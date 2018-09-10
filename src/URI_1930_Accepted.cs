using System; 

class URI {

    static void Main(string[] args) { 

        string[] t = Console.ReadLine().Split();
            int t1 = int.Parse(t[0]);
            int t2 = int.Parse(t[1]);
            int t3 = int.Parse(t[2]);
            int t4 = int.Parse(t[3]);
            Console.WriteLine(t1 - 1 + t2 - 1 + t3 - 1 + t4);

    }

}
