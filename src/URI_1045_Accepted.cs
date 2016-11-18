using System; 

class URI {

    static void Main(string[] args) { 

            double a, b, c, aux;
            string[] valor = Console.ReadLine().Split();
            a = Convert.ToDouble(valor[0]);
            b = Convert.ToDouble(valor[1]);
            c = Convert.ToDouble(valor[2]);

            if (a < b)
            {
                aux = a;
                a = b;
                b = aux;
            }
            if (b < c)
            {
                aux = b;
                b = c;
                c = aux;
            }
            if (a < b)
            {
                aux = a;
                a = b;
                b = aux;
            }

            if (a >= b + c)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else if (a * a == b * b + c * c)
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            else if(a * a > b * b + c * c)
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            else if (a * a < b * b + c * c)
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }
            if(a == b && b == c)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            else if(a == b || b == c)
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }

    }

}