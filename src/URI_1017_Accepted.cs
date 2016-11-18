using System; 

class URI {

    static void Main(string[] args) { 

            int tempoViagem, velocidadeMedia; 
            double qtdLitros;

            tempoViagem = Convert.ToInt32(Console.ReadLine());

            velocidadeMedia = Convert.ToInt32(Console.ReadLine());

            qtdLitros = (tempoViagem * velocidadeMedia) / 12.0;

            Console.WriteLine(qtdLitros.ToString("0.000"));

    }

}