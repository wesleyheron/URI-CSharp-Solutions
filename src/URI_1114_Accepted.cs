using System; 

class URI {

    static void Main(string[] args) { 

            int senha;
            do
            {
                senha = Convert.ToInt32(Console.ReadLine());
                if (senha != 2002)
                {
                    Console.WriteLine("Senha Invalida");
                }
                else if(senha == 2002)
                {
                    Console.WriteLine("Acesso Permitido");
                    break;
                }
            }
            while (true);

    }

}