using System; 

class URI {

    static void Main(string[] args) { 

        int qt = int.Parse(Console.ReadLine());
            for (int i = 0; i < qt; i++)
            {
                string v = Console.ReadLine();
                char[] arr = v.ToCharArray();
                float qtArr = arr.Length;
                float total = (qtArr / 100);
                Console.WriteLine("{0:0.00}", total);
            }

    }

}
