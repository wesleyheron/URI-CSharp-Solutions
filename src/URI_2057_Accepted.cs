using System; 

class URI {

    static void Main(string[] args) { 

        string[] v = Console.ReadLine().Split();
            int s = int.Parse(v[0]);
            int t = int.Parse(v[1]);
            int f = int.Parse(v[2]);

            int res = s + t + f;
            if (res == 24)
                Console.WriteLine(res = 0);
            else if (res > 24)
                Console.WriteLine(res -= 24);            
            else if (res < 24 && res > 0)
                Console.WriteLine(res);
            else if(res < 0)
                Console.WriteLine(res += 24);
            else if(res == 0)
                Console.WriteLine(res);

    }

}
