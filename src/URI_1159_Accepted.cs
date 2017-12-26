using System; 

class URI {

    static void Main(string[] args) { 

            int n;
            do
            {
                int soma = 0;
                int cont = 0;

                n = Convert.ToInt32(Console.ReadLine());
                
                if (n == 0)
                    break;
                
                while (cont < 5)
                {
                    if(n % 2 == 0)
                    {
                        cont++;
                        soma += n;
                    }
                    n++;
                }
                Console.WriteLine("{0}", soma);
                
            }
            while (true);

    }

}