using System; 

class URI {

    static void Main(string[] args) { 

            int n = Convert.ToInt32(Console.ReadLine());            
            for(int i = 0; i < n; i++)
            {
                int soma = 0;
                string[] qtdTestes = Console.ReadLine().Split();
                int x = Convert.ToInt32(qtdTestes[0]);
                int y = Convert.ToInt32(qtdTestes[1]);
                if(x > y)
                {
                    int aux = x;
                    x = y;
                    y = aux;
                }
                
                for(int j = x + 1; j < y; j++)
                {
                    if(j % 2 != 0)
                    {
                        soma += j;                        
                    }
                    
                }
                Console.WriteLine(soma);
            }

    }

}