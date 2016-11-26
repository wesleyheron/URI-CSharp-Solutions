using System; 

class URI {

    static void Main(string[] args) { 

            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int soma = 0;
            if(x > y)
            {
                int aux = y;
                y = x;
                x = aux;
            }
            for(int i = x; i <= y; i++)
            {
                if(i % 13 != 0)
                {
                    soma += i;
                }
            }
            Console.WriteLine(soma);

    }

}