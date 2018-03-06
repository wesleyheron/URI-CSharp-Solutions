using System; 

class URI {

    static void Main(string[] args) { 

            int nTestes = int.Parse(Console.ReadLine());

            for (int i = 0; i < nTestes; i++)
            {
                double qtdComida = Convert.ToDouble(Console.ReadLine());
                int qtdDias = 0;
                while (qtdComida > 1)
                {
                    qtdComida /= 2;
                    qtdDias++;
                }
                Console.WriteLine("{0} dias", qtdDias);
            }

    }

}