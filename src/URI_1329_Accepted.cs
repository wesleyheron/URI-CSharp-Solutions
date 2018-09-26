using System; 

class URI {

    static void Main(string[] args) { 

        int qt = int.Parse(Console.ReadLine());
        do
        {
            int qtM = 0;
            int qtJ = 0;
            if (qt == 0)
                break;
            string[] v = Console.ReadLine().Split();
                for (int j = 0; j < v.Length; j++)
                {
                    if (int.Parse(v[j]) == 0)
                        qtM++;
                    else
                        qtJ++;
                }
                Console.WriteLine("Mary won {0} times and John won {1} times", qtM, qtJ);
            
            
            qt = int.Parse(Console.ReadLine());

        } while (qt != 0);

    }

}
