using System;

class URI
{
    static void Main(string[] args)
    {
        int qt = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < qt; i++)
        {
            string cc = string.Empty;
            string c = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            for (int j = 0; j < c.Length; j++)
            {
                var position = c[j] - n;
                if (position < 65)
                    position += 26;
                Console.Write("{0}", (char) position);                                    
            }
            Console.WriteLine();
        }
    }

}
