using System; 

class URI {

    static void Main(string[] args) { 

            string valor;
            long x, y;
                        
            while ((valor = Console.ReadLine()) != null)
            {
                string[] valores = valor.Split();
                x = long.Parse(valores[0]);
                y = long.Parse(valores[1]);
                long resultado = x ^ y;
                Console.WriteLine(resultado);
            }

    }

}