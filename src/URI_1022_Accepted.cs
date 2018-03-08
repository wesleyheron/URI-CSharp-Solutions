using System; 

class URI {

    static int Mdc(int n, int m)
        {
            if (n < 0)
                n = -n;
            if (m < 0)
                m = -m;
            if (n % m == 0)
                return m;
            else
                return Mdc(m, n % m);
        }


    static void Main(string[] args) { 

            int qtdTeste = int.Parse(Console.ReadLine());
            int n1, n2, d1, d2, div;
            char op;
            int numerador = 0, denominador = 0;
            for (int i = 0; i < qtdTeste; i++)
            {
                string[] valores = Console.ReadLine().Split();
                n1 = int.Parse(valores[0]);                
                d1 = int.Parse(valores[2]);

                op = char.Parse(valores[3]);

                n2 = int.Parse(valores[4]);
                d2 = int.Parse(valores[6]);

                
                switch (op)
                {
                    case '+':
                        numerador = (n1 * d2 + n2 * d1);
                        denominador = (d1 * d2);
                        div = Mdc(numerador, denominador);
                        Console.WriteLine("{0}/{1} = {2}/{3}", numerador, denominador, numerador / div, denominador / div);
                        break;
                    case '-':
                        numerador = (n1 * d2 - n2 * d1);
                        denominador = (d1 * d2);
                        div = Mdc(numerador, denominador);
                        Console.WriteLine("{0}/{1} = {2}/{3}", numerador, denominador, numerador / div, denominador / div);
                        break;
                    case '*':
                        numerador = (n1 * n2);
                        denominador = (d1 * d2);
                        div = Mdc(numerador, denominador);
                        Console.WriteLine("{0}/{1} = {2}/{3}", numerador, denominador, numerador / div, denominador / div);
                        break;
                    case '/':
                        numerador = (n1 * d2);
                        denominador = (n2 * d1); 
                        div = Mdc(numerador, denominador);
                        Console.WriteLine("{0}/{1} = {2}/{3}", numerador, denominador, numerador / div, denominador / div);
                        break;
                    default:
                        break;
                }
                
            }

    }

}