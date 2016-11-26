using System; 

class URI {

    static void Main(string[] args) { 

            double i = 0, j = 1;
            for (i = 0; i <= 2; i+=0.2)
            {
                Console.WriteLine("I={0} J={1}", i, j);
                Console.WriteLine("I={0} J={1}", i, j + 1);
                Console.WriteLine("I={0} J={1}", i, j + 2);
                j += 0.2;
            }

    }

}