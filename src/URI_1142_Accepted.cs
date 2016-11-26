using System; 

class URI {

    static void Main(string[] args) { 

            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < n * 4; i += 4)
            {
                Console.WriteLine("{0} {1} {2} PUM", i + 1, i + 2, i + 3);                
            }

    }

}