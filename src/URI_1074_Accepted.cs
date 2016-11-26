using System; 

class URI {

    static void Main(string[] args) { 

            long numeroDeTestes;
            numeroDeTestes = Convert.ToInt64(Console.ReadLine());
            for (long i = 0; i < numeroDeTestes; i++)
            {
                long numeros = Convert.ToInt64(Console.ReadLine());
                if (numeros == 0)
                {
                    Console.WriteLine("NULL");
                }
                else if (numeros < 0 && numeros % 2 == 0)
                {
                    Console.WriteLine("EVEN NEGATIVE");
                }
                else if (numeros < 0 && numeros % 2 != 0)
                {
                    Console.WriteLine("ODD NEGATIVE");
                }
                else if (numeros > 0 && numeros % 2 != 0)
                {
                    Console.WriteLine("ODD POSITIVE");
                }
                else if (numeros > 0 && numeros % 2 == 0)
                {
                    Console.WriteLine("EVEN POSITIVE");
                }
                
            }

    }

}