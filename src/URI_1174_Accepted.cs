using System; 

class URI {

    static void Main(string[] args) { 

            double[] a = new double[100];

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = double.Parse(Console.ReadLine());
                
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] <= 10)
                {
                    Console.WriteLine("A[{0}] = {1:0.0}", i, a[i]);
                }
            }

    }

}