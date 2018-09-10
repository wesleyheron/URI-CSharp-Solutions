using System; 

class URI {

    static void Main(string[] args)
        {
            string[] t = Console.ReadLine().Split();
            int t1 = int.Parse(t[0]);
            int t2 = int.Parse(t[1]);           
            Console.WriteLine(GetMax(t1, t2));
            
        }
        public static int GetMax(int first, int second)
        {
            return first > second ? first : second;
        }

}
