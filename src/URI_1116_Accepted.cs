using System; 

class URI {

    static void Main(string[] args) { 

            int n = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split();
                double a = Convert.ToDouble(valores[0]);
                double b = Convert.ToDouble(valores[1]);
                
                if(b == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    Console.WriteLine("{0:0.0}", a / b);
                }
            }

    }

}