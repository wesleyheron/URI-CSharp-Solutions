using System; 

class URI {

    static void Main(string[] args) { 

            double nota;
            double soma = 0;
            int op = 0;
            double notaValida = 0;
            do
            {
                nota = Convert.ToDouble(Console.ReadLine());
                if (nota >= 0 && nota <= 10)
                {
                    notaValida++;
                    soma += nota;
                }
                else
                {
                    Console.WriteLine("nota invalida");
                }
                if (notaValida == 2)
                {
                    Console.WriteLine("media = {0:0.00}", (soma / 2.00));
                    do
                    {
                        Console.WriteLine("novo calculo (1-sim 2-nao)");
                        op = Convert.ToInt32(Console.ReadLine());
                        if (op == 2)
                        {
                            return;
                        }
                        else if (op == 1)
                        {
                            notaValida = 0;
                            soma = 0;
                            continue;
                        }
                    }
                    while (op != 1 && op != 2);                    
                                        
                }
            }
            while (true);

    }

}