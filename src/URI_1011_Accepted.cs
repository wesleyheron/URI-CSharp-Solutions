using System; 

class URI {

    static void Main(string[] args) { 

            double vol, raio;
            double pi = 3.14159;

            raio = Convert.ToDouble(Console.ReadLine());

            vol = (4.0 / 3) * pi * (raio * raio * raio);

            Console.WriteLine("VOLUME = {0:0.000}", vol);

    }

}