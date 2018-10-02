using System; 

class URI {

    static void Main(string[] args) { 

       string v;
        while ((v = Console.ReadLine()) != null)
        {
            int a = int.Parse(v[0].ToString());
            int b = int.Parse(v[2].ToString());
            int c = int.Parse(v[4].ToString());

            if (a == b && b == c)
                Console.WriteLine("*");
            else if(a != b && b == c)
                Console.WriteLine("A");
            else if (b != a && a == c)
                Console.WriteLine("B");
            else if (c != a && a == b )
                Console.WriteLine("C");
            
        }

    }

}
