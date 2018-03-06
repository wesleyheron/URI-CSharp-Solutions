using System; 

class URI {

    static void Main(string[] args) { 

            int[] n = new int[20];
            int[] newArray = new int[20];
            int t = 19;
            for (int i = 0; i < n.Length; i++)
            {
                n[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n.Length; i++)
            {
                newArray[i] = n[t];
                t--;
            }
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine("N[{0}] = {1}", i, newArray[i]);
            }

    }

}