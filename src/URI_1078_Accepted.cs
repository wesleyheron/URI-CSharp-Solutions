using System; 

class URI {

    static void Main(string[] args) { 

            int n = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", i, n, i*n);
            }

    }

}