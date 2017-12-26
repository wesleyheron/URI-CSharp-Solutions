using System; 

class URI {

    static void Main(string[] args) { 

            int n = Convert.ToInt32(Console.ReadLine());            

            for (int i = 0; i < n; i++)
            {
                
                string[] qtdTestes = Console.ReadLine().Split();

                int x = Convert.ToInt32(qtdTestes[0]);
                int y = Convert.ToInt32(qtdTestes[1]);
                int soma = 0;
                int qtd = 0;

                while (qtd < y)
                {
                    if(x % 2 != 0)
                    {
                        qtd++;
                        soma+=x;
                    }
                    x++;
                }
               
                Console.WriteLine("{0}", soma);

            }

    }

}