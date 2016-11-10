using System; 

class URI {

    static void Main(string[] args) { 

            string nomeVendedor;
            double salarioFixo, totalDeVendasEfetuadas, totalAReceber;

            nomeVendedor = Console.ReadLine();

            salarioFixo = Convert.ToDouble(Console.ReadLine());

            totalDeVendasEfetuadas = Convert.ToDouble(Console.ReadLine());

            totalAReceber = salarioFixo + (totalDeVendasEfetuadas * 0.15);

            Console.WriteLine("TOTAL = R$ {0:0.00}", Math.Round(totalAReceber,2));

    }

}