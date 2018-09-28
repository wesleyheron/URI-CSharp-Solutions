using System; 

class URI {

    static void Main(string[] args) { 

        int qt;        
        do
        {
            qt = int.Parse(Console.ReadLine());
            int qtA = 0;
            int qtB = 0;
            if (qt == 0)
                break;
            for (int i = 0; i < qt; i++)
            {

                string[] v = Console.ReadLine().Split();
                int a = int.Parse(v[0]);
                int b = int.Parse(v[1]);
                if (a > b)
                    qtA++;
                else if (b > a)
                    qtB++;
            }
            Console.WriteLine("{0} {1}", qtA, qtB);

        } while (qt != 0);

    }

}
