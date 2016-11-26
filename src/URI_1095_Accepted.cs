using System; 

class URI {

    static void Main(string[] args) { 

        int i = 0, j = 60;
            for(i = 1, j = 60; j <= 60; i += 3, j-=5)
            {
                Console.WriteLine("I={0} J={1}", i, j);
                if (j == 0)
                    break;
            }

    }

}