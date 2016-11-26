using System; 

class URI {

    static void Main(string[] args) { 

            int i = 1, j = 7;
            for (i = 1; i <= 9; i++)
            {
                Console.WriteLine("I={0} J={1}", i, j);
                Console.WriteLine("I={0} J={1}", i, j - 1);
                Console.WriteLine("I={0} J={1}", i, j - 2);
                i++;
                j += 2;

            }

    }

}