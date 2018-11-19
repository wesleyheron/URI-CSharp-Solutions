using System; 

class URI {

    static void Main(string[] args) { 

        int c = int.Parse(Console.ReadLine());
        string[] arr = { "PROXYCITY", "P.Y.N.G.", "DNSUEY!", "SERVERS", "HOST!", "CRIPTONIZE", "OFFLINE DAY", "SALT", "ANSWER!", "RAR?", "WIFI ANTENNAS" };
        for (int i = 0; i < c; i++)
        {
            string[] btns = Console.ReadLine().Split();
            int x = int.Parse(btns[0]);
            int y = int.Parse(btns[1]);
            Console.WriteLine("{0}", arr[x+y]); 
        }

    }

}
