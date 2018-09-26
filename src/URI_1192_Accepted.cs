using System; 
using System.Linq;

class URI {

    static void Main(string[] args) { 

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string v = Console.ReadLine();
            char[] arr = v.ToArray();
                        
            int a = int.Parse(arr[0].ToString());
            int b = int.Parse(arr[2].ToString());            

            if (a == b)
                Console.WriteLine("{0}", a * b);
            else if (char.IsUpper(arr[1]))
                Console.WriteLine("{0}", b - a);
            else if (char.IsLower(arr[1]))
                Console.WriteLine("{0}", a + b);

        }

    }

}
