using System; 

class URI {

    static void Main(string[] args) { 

            int n = Convert.ToInt32(Console.ReadLine());            
                        
            for (int i = 0; i < n; i++)
            {                
                int x = Convert.ToInt32(Console.ReadLine());
                int soma = 0;

                for (int j = 1; j < x; j++)
                {
                    if(x % j == 0)
                    {
                        soma += j;
                    }
                }
                if (soma == x)
                {
                    Console.WriteLine("{0} eh perfeito", x);
                }
                else
                {
                    Console.WriteLine("{0} nao eh perfeito", x);
                }

            }

    }

}