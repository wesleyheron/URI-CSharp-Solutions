using System; 

class URI {

    static void Main(string[] args) { 

            double area, raio;
            double pi = 3.14159;

            raio = Convert.ToDouble(Console.ReadLine());

            area = pi * (raio * raio);

            Console.WriteLine("A={0}",area.ToString("0.0000"));

    }

}