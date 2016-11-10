using System; 

class URI {

    static void Main(string[] args) { 

            int duracaoEvento, hora, minuto, segundo;

            duracaoEvento = Convert.ToInt32(Console.ReadLine());

            hora = duracaoEvento / 3600;
            segundo = duracaoEvento % 3600;
            minuto = segundo / 60;
            segundo = segundo % 60;

            Console.WriteLine("{0}:{1}:{2}", hora, minuto, segundo);

    }

}