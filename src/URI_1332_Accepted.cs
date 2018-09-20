using System; 

class URI {

    static void Main(string[] args) { 

        int qt = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < qt; i++)
        {
            string c = Console.ReadLine();
            if (c.Length > 3)
                Console.WriteLine(3);
            else if ((c.StartsWith("o") && c.EndsWith("e")) || (c.Substring(1, c.Length - 2) == "n" && c.EndsWith("e")) || (c.StartsWith("o") && c.Substring(1, c.Length - 2) == "n"))
                Console.WriteLine(1);
            else
                Console.WriteLine(2);


        }

    }

}
