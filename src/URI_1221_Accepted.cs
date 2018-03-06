using System; 

class URI {

    static void Main(string[] args) { 

            int n = int.Parse(Console.ReadLine());
            long valor;
            int raiz = 0;
                                    
            for (int i = 0; i < n; i++)
            {
                int primo = 0;
                valor = long.Parse(Console.ReadLine());
                if (valor == 0 || valor == 1)
                    Console.WriteLine("Not Prime");
                else
                    primo = 1;

                raiz = Convert.ToInt32(Math.Sqrt(valor));

                for (int j = 2; j <= raiz; j++)
                {
                    if (valor % j == 0)
                    {
                        primo = 0;
                        break;
                    }
                                            
                }
                if (primo == 1)
                    Console.WriteLine("Prime");
                else
                    Console.WriteLine("Not Prime");
            }

    }

}