using System; 

class URI {

    static void Main(string[] args) { 

            int cod1, numPec1, cod2, numPec2;
            double valUnitPec1, valUnitPec2, valAPagar;

            string[] items1 = Console.ReadLine().Split();

            cod1 = Convert.ToInt32(items1[0]);
            numPec1 = Convert.ToInt32(items1[1]);
            valUnitPec1 = Convert.ToDouble(items1[2]);

            string[] items2 = Console.ReadLine().Split();

            cod2 = Convert.ToInt32(items2[0]);
            numPec2 = Convert.ToInt32(items2[1]);
            valUnitPec2 = Convert.ToDouble(items2[2]);

            valAPagar = (numPec1 * valUnitPec1) + (numPec2 * valUnitPec2);

            Console.WriteLine("VALOR A PAGAR: R$ {0:0.00}", valAPagar);
    }

}