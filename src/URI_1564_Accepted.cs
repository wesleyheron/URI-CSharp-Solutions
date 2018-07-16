using System; 

class URI {

    static void Main(string[] args) { 

            string valor;

            while ((valor = Console.ReadLine()) != null)
            {
                int n = int.Parse(valor);
                if (n == 0)
                    Console.WriteLine("vai ter copa!");
                else
                    Console.WriteLine("vai ter duas!");
            }

    }

}
