using System; 

class URI {

    static void Main(string[] args) { 

        string[] v = Console.ReadLine().Split();
            int temp;
            int a = int.Parse(v[0]);
            int b = int.Parse(v[1]);
            int c = int.Parse(v[2]);
            int d = int.Parse(v[3]);
            if(a < b)
            {
                temp = a;
                a = b;
                b = temp;
            }
            if (a < c)
            {
                temp = a;
                a = c;
                c = temp;
            }
            if (a < d)
            {
                temp = a;
                a = d;
                d = temp;
            }
            if (b < c)
            {
                temp = b;
                b = c;
                c = temp;
            }
            if (b < d)
            {
                temp = b;
                b = d;
                d = temp;
            }
            if (c < d)
            {
                temp = c;
                c = d;
                d = temp;
            }

            if (a < b + c || b < c + d)
                Console.WriteLine("S");
            else
                Console.WriteLine("N");

    }

}
