using System; 

class URI {

    static void Main(string[] args) { 

        string frase;
        while ((frase = Console.ReadLine()) != null)
        {
            switch (frase)
            {
                case "esquerda":
                    Console.WriteLine("ingles");
                    break;
                case "direita":
                    Console.WriteLine("frances");
                    break;
                case "nenhuma":
                    Console.WriteLine("portugues");
                    break;
                case "as duas":
                    Console.WriteLine("caiu");
                    break;
            }
        }

    }

}
