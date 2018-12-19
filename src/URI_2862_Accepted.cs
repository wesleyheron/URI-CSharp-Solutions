using System; 

class URI {

    static void Main(string[] args) { 

        int qt = int.Parse(Console.ReadLine());
        for (int i = 0; i < qt; i++)
        {
            int energy = int.Parse(Console.ReadLine());
            if(energy <= 8000)
                Console.WriteLine("Inseto!");
            else
                Console.WriteLine("Mais de 8000!");
        }

    }

}
