using System; 

class URI {

    static void Main(string[] args) { 

        while (true)
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 0)
                break;
            string v = Console.ReadLine();
            char[] arr = v.ToCharArray();
            int position = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                
                if (arr[i] == 'D')
                    position = (position + 1) % 4;
                else
                    position = (position - 1 < 0 ? 3 : position - 1);                

            }
            switch (position)
            {
                case 0:
                    Console.WriteLine("N");
                    break;
                case 1:
                    Console.WriteLine("L");
                    break;
                case 2:
                    Console.WriteLine("S");
                    break;
                case 3:
                    Console.WriteLine("O");
                    break;
            }
        }

    }

}
