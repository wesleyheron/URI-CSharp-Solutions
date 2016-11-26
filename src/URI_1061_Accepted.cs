using System; 

class URI {

    static void Main(string[] args) { 

            int diaInicio, diaTermino, horaMomentoInicio, minutoMomentoInicio, segundoMomentoInicio;
            int horaMomentoTermino, minutoMomentoTermino, segundoMomentoTerminio;

            string[] dadosInicio = Console.ReadLine().Split();
            diaInicio = Convert.ToInt32(dadosInicio[1]);

            string[] dadosMomentoInicio = Console.ReadLine().Split();
            horaMomentoInicio = Convert.ToInt32(dadosMomentoInicio[0]);
            minutoMomentoInicio = Convert.ToInt32(dadosMomentoInicio[2]);
            segundoMomentoInicio = Convert.ToInt32(dadosMomentoInicio[4]);

            string[] dadosTermino = Console.ReadLine().Split();
            diaTermino = Convert.ToInt32(dadosTermino[1]);

            string[] dadosMomentoTermino = Console.ReadLine().Split();
            horaMomentoTermino = Convert.ToInt32(dadosMomentoTermino[0]);
            minutoMomentoTermino = Convert.ToInt32(dadosMomentoTermino[2]);
            segundoMomentoTerminio = Convert.ToInt32(dadosMomentoTermino[4]);

            int transformaSegundosInicio = (segundoMomentoInicio + minutoMomentoInicio * 60 + horaMomentoInicio * 60 * 60 + diaInicio * 60 * 60 * 24);
            int transformaSegundosTermino = (segundoMomentoTerminio + minutoMomentoTermino * 60 + horaMomentoTermino * 60 * 60 + diaTermino * 60 * 60 * 24);

            int somaTotalSegundos = (transformaSegundosTermino - transformaSegundosInicio);
            int W = somaTotalSegundos / (60 * 60 * 24);
            int X = (somaTotalSegundos - W * 60 * 60 * 24) / (60 * 60);
            int Y = (somaTotalSegundos - W * 60 * 60 * 24 - X * 60 * 60) / 60;
            int Z = somaTotalSegundos - W * 60 * 60 * 24 - X * 60 * 60 - Y * 60;

            Console.WriteLine("{0} dia(s)", W);
            Console.WriteLine("{0} hora(s)", X);
            Console.WriteLine("{0} minuto(s)", Y);
            Console.WriteLine("{0} segundo(s)", Z);

    }

}