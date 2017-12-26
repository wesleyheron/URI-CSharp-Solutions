using System; 

class URI {

    static void Main(string[] args) { 

            int n = Convert.ToInt32(Console.ReadLine());
            int fat = 1;
            for(int i = n; i >= 1; i--)
            {
                fat *= i;
            }
            Console.WriteLine(fat);

    }

}