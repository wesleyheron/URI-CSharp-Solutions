using System; 

class URI {

    static void Main(string[] args) { 

            int nTestes = int.Parse(Console.ReadLine());

            for (int i = 0; i < nTestes; i++)
            {
                string[] valorLido = Console.ReadLine().Split();
                int f1 = int.Parse(valorLido[0]);
                int f2 = int.Parse(valorLido[1]);
                int aux, mdc;
                if (f1 < f2)
                {
                    aux = f1;
                    f1 = f2;
                    f2 = aux;
                }
                while (f1 % f2 != 0)
                {
                    mdc = f1;
                    f1 = f2;
                    f2 = mdc % f2;
                }
                
                Console.WriteLine(f2);
            }

    }

}