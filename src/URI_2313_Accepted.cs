using System; 

class URI {

    static void Main(string[] args) { 

        string[] lado = Console.ReadLine().Split();
        int aux, aa, bc;
        int a = int.Parse(lado[0]);
        int b = int.Parse(lado[1]);
        int c = int.Parse(lado[2]);

        if(b > a)
        {
            aux = a;
            a = b;
            b = aux;
        }
        if (c > a)
        {
            aux = a;
            a = c;
            c = aux;
        }
        aa = a * a;
        bc = ((c * c) + (b * b));
        if(a >= b + c)
            Console.WriteLine("Invalido");
        else
        {
            if (a == b && b == c)
                Console.WriteLine("Valido-Equilatero");
            else if (a == b || a == c || b == c)
                Console.WriteLine("Valido-Isoceles");            
            else
                Console.WriteLine("Valido-Escaleno");
            if(aa == bc)
                Console.WriteLine("Retangulo: S");
            else
                Console.WriteLine("Retangulo: N");
        }

    }

}
