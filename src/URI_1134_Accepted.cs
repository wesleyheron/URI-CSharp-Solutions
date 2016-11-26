using System; 

class URI {

    static void Main(string[] args) { 

            int alcool = 0, gasolina = 0, diesel = 0;
            int cod;
            do
            {
                
                cod = Convert.ToInt32(Console.ReadLine());
                
                switch (cod)
                {
                    case 1:
                        alcool++;
                        continue;
                    case 2:
                        gasolina++;
                        continue;
                    case 3:
                        diesel++;
                        continue;
                    case 4:
                        Console.WriteLine("MUITO OBRIGADO");
                        Console.WriteLine("Alcool: {0}", alcool);
                        Console.WriteLine("Gasolina: {0}", gasolina);
                        Console.WriteLine("Diesel: {0}", diesel);
                        break;
                    default:                       
                        continue;
                }
            }
            while (cod != 4);

    }

}