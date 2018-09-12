using System; 

class URI {

    static void Main(string[] args) { 

       string valor;
            int minTotal;            
            while ((valor = Console.ReadLine()) != null)
            {
                string[] h = valor.Split(':');
                minTotal = 0;
                if (int.Parse(h[0]) >= 8)
                {
                    minTotal = int.Parse(h[1]) + 60 * (int.Parse(h[0]) - 7);
                    Console.WriteLine("Atraso maximo: {0}", minTotal);
                }
                else if (int.Parse(h[0]) + 1 >= 8)
                    Console.WriteLine("Atraso maximo: {0}", int.Parse(h[1]));
                else
                    Console.WriteLine("Atraso maximo: {0}", minTotal);
            }

    }

}
