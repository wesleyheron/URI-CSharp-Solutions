using System; 

class URI {

    static void Main(string[] args) { 

        int numero = Convert.ToInt32(Console.ReadLine());
            int totalLoops = 0;
            while(totalLoops < 6)
            {
                if(numero % 2 != 0)
                {
                    Console.WriteLine(numero);
                    totalLoops++;
                }
                numero++;
                
            }

    }

}