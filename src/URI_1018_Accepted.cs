using System; 

class URI {

    static void Main(string[] args) { 

            int qtd, cedulas;

            qtd = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(qtd);

            cedulas = (qtd - (qtd % 100)) / 100;
            Console.WriteLine("{0} nota(s) de R$ 100,00", cedulas);
            qtd = qtd % 100;

           
            cedulas = (qtd - (qtd % 50)) / 50;
            Console.WriteLine("{0} nota(s) de R$ 50,00", cedulas);
            qtd = qtd % 50;

            cedulas = (qtd - (qtd % 20)) / 20;
            Console.WriteLine("{0} nota(s) de R$ 20,00", cedulas);
            qtd = qtd % 20;

            cedulas = (qtd - (qtd % 10)) / 10;
            Console.WriteLine("{0} nota(s) de R$ 10,00", cedulas);
            qtd = qtd % 10;

            cedulas = (qtd - (qtd % 5)) / 5;
            Console.WriteLine("{0} nota(s) de R$ 5,00", cedulas);
            qtd = qtd % 5;

            cedulas = (qtd - (qtd % 2)) / 2;
            Console.WriteLine("{0} nota(s) de R$ 2,00", cedulas);
            qtd = qtd % 2;

            cedulas = (qtd - (qtd % 1)) / 1;
            Console.WriteLine("{0} nota(s) de R$ 1,00", cedulas);
            qtd = qtd % 1;

    }

}