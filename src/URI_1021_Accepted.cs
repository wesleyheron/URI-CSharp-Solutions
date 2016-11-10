using System; 

class URI {

    static void Main(string[] args) { 

            double valor;
            int inteiro, auxNotas, auxMoedas;

            
            valor = Convert.ToDouble(Console.ReadLine());

            inteiro = (int)valor;
            valor *= 100;
            auxMoedas = (int)valor;


            Console.WriteLine("NOTAS:");
            Console.WriteLine("{0} nota(s) de R$ 100.00", inteiro/100);
            auxNotas = (inteiro % 100);
            Console.WriteLine("{0} nota(s) de R$ 50.00", auxNotas/50);
            auxNotas %= 50;
            Console.WriteLine("{0} nota(s) de R$ 20.00", auxNotas/20);
            auxNotas %= 20;
            Console.WriteLine("{0} nota(s) de R$ 10.00", auxNotas/10);
            auxNotas %= 10;
            Console.WriteLine("{0} nota(s) de R$ 5.00", auxNotas/5);
            auxNotas %= 5;
            Console.WriteLine("{0} nota(s) de R$ 2.00", auxNotas/2);
            auxNotas %= 2;

            Console.WriteLine("MOEDAS:");
            Console.WriteLine("{0} moeda(s) de R$ 1.00", auxNotas / 1);
            auxMoedas %= 100;
            Console.WriteLine("{0} moeda(s) de R$ 0.50", auxMoedas/50);
            auxMoedas %= 50;
            Console.WriteLine("{0} moeda(s) de R$ 0.25", auxMoedas/25);
            auxMoedas %= 25;
            Console.WriteLine("{0} moeda(s) de R$ 0.10", auxMoedas / 10);
            auxMoedas %= 10;
            Console.WriteLine("{0} moeda(s) de R$ 0.05", auxMoedas / 5);
            auxMoedas %= 5;
            Console.WriteLine("{0} moeda(s) de R$ 0.01", auxMoedas / 1);

    }

}