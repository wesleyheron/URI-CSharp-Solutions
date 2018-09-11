using System; 

class URI {

    static void Main(string[] args) { 

        
            string[] ap = Console.ReadLine().Split();
            int p = int.Parse(ap[0]);
            int n = int.Parse(ap[1]);
            string[] nc = Console.ReadLine().Split();
            int diff;
            for (int i = 1; i < n; i++)
            {                             
                diff = Math.Abs(int.Parse(nc[i]) - int.Parse(nc[i - 1]));
                if (diff > p)
                {
                    Console.WriteLine("GAME OVER");
                    return;
                }              

            }
            Console.WriteLine("YOU WIN");

    }

}
