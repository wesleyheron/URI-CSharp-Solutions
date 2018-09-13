using System; 

class URI {

    static void Main(string[] args) { 

        string v = Console.ReadLine();
            char[] arr = v.ToCharArray();
            if(arr.Length <= 80)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");

    }

}
