using System; 

class URI {

    static void Main(string[] args) { 

            int qtdTeste = int.Parse(Console.ReadLine());
            long a = 0, b = 1, proximoTermo;
            long[] vetor = new long[61];
            vetor[0] = a;
            vetor[1] = b;
            
            for (int i = 2; i < vetor.Length; i++)
            {
                proximoTermo = a + b;
                vetor[i] = proximoTermo;
                a = b;
                b = proximoTermo;
            }
            for (int i = 0; i < qtdTeste; i++)
            {
                long valor = long.Parse(Console.ReadLine());

                Console.WriteLine("Fib({0}) = {1}", valor, vetor[valor]);
                
            }

    }

}