using System; 

class URI {

    static void Main(string[] args) { 

            int qtdTeste = int.Parse(Console.ReadLine());            
            char[] valores;
            string valor;
            
            for (int i = 0; i < qtdTeste; i++)
            {
                valor = Console.ReadLine();
                valores = valor.ToCharArray();
                int qtdLeds = 0;
                for (int j = 0; j < valores.Length; j++)
                {
                    if (valores[j] == '2' || valores[j] == '3' || valores[j] == '5')
                        qtdLeds += 5;
                    if (valores[j] == '6' || valores[j] == '9' || valores[j] == '0')
                        qtdLeds += 6;
                    if (valores[j] == '1')
                        qtdLeds += 2;
                    if (valores[j] == '4')
                        qtdLeds += 4;
                    if (valores[j] == '7')
                        qtdLeds += 3;
                    if (valores[j] == '8')
                        qtdLeds += 7;
                }
                Console.WriteLine("{0} leds", qtdLeds);

            }

    }

}