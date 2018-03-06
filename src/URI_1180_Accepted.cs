using System; 

class URI {

    static void Main(string[] args) { 

            int n = int.Parse(Console.ReadLine());
            int[] x = new int[n];
            int cont = 0, menorValor = 0, posicaoMenorValor = 0;

            string[] valoresLidos = Console.ReadLine().Split();

            while (cont < x.Length)
            {                

                x[cont] = int.Parse(valoresLidos[cont]);                
                if (x[cont] < menorValor)
                {
                    menorValor = x[cont];
                    posicaoMenorValor = cont;
                }
                    
                cont++;
            }
            Console.WriteLine("Menor valor: {0}", menorValor);
            Console.WriteLine("Posicao: {0}", posicaoMenorValor);

    }

}