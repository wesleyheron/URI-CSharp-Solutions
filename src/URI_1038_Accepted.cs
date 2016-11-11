using System; 

class URI {

    static void Main(string[] args) { 

            string[] valor = Console.ReadLine().Split();
            int cod, qtd;

            cod = Convert.ToInt32(valor[0]);
            qtd = Convert.ToInt32(valor[1]);

            switch (cod)
            {
                case 1:
                    Console.WriteLine("Total: R$ {0:0.00}", qtd * 4.00);
                    break;
                case 2:
                    Console.WriteLine("Total: R$ {0:0.00}", qtd * 4.50);
                    break;
                case 3:
                    Console.WriteLine("Total: R$ {0:0.00}", qtd * 5.00);
                    break;
                case 4:
                    Console.WriteLine("Total: R$ {0:0.00}", qtd * 2.00);
                    break;
                case 5:
                    Console.WriteLine("Total: R$ {0:0.00}", qtd * 1.50);
                    break;

            }

    }

}