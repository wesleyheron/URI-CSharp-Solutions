using System; 

class URI {

    static void Main(string[] args) { 

            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int aux;

            if (x > y)
            {
                aux = x;
                x = y;
                y = aux;
            }
            int soma = 0;
            

            for (int i = x + 1; i < y; i++)
            {
                if (i % 2 != 0)
                {
                    soma +=i;
                }
                    
            }
            Console.WriteLine(soma);

    }

}