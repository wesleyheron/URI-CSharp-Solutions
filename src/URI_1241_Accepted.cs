using System.IO;
using System.Linq;

class URI
{

    static void Main(string[] args)
    {
        int qt = int.Parse(Console.ReadLine());
        for (int i = 0; i < qt; i++)
        {
            int bufSize = 2024;
            Stream inStream = Console.OpenStandardInput(bufSize);
            Console.SetIn(new StreamReader(inStream, Console.InputEncoding, false, bufSize));
            string[] v = Console.ReadLine().Split();
            string a = v[0];
            string b = v[1];

            if (b.Length > a.Length)
                Console.WriteLine("nao encaixa");
            else if (a.Substring(a.Length - b.Length) == b)
                Console.WriteLine("encaixa");
            else
                Console.WriteLine("nao encaixa");

        }

    }

}
