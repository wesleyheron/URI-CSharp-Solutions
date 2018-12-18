using System; 

class URI {

    static void Main(string[] args) { 

        int qTeste = int.Parse(Console.ReadLine());
        for (int i = 0; i < qTeste; i++)
        {
            string newText = string.Empty;
            string[] line = Console.ReadLine().Split();
            foreach (var item in line)
            {
                if(item != "")
                {
                    newText += item.Substring(0, 1);
                }
               
            }
            Console.WriteLine(newText);
        }

    }

}
