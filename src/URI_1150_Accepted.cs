using System; 

class URI {

    static void Main(string[] args) { 

            int x = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());
            int soma = 1;
            int i = x + 1;
            
            while (z <= x)
            {
                z = Convert.ToInt32(Console.ReadLine());
                
            }

            while(x <= z)
            {
                soma++;
                x += i;
                i++;
            }
            Console.WriteLine(soma);

    }

}