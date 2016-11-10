using System; 

class URI {

    static void Main(string[] args) { 

            int numero, hora;
            double valorHora, salario;

            numero = Convert.ToInt32(Console.ReadLine());
            hora = Convert.ToInt32(Console.ReadLine());

            valorHora = Convert.ToDouble(Console.ReadLine());

            salario = hora * valorHora;

            Console.WriteLine("NUMBER = {0}", numero);
            Console.WriteLine("SALARY = U$ {0:0.00}", salario);

    }

}