using System; 

class URI {

    static void Main(string[] args) { 

            int numero = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= numero; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

    }

}