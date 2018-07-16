using System;
using System.Linq;

class URI {

    static void Main(string[] args) { 

            int qtdTeste = int.Parse(Console.ReadLine());
            string[] valor;
            for (int i = 0; i < qtdTeste; i++)
            {
                valor = Console.ReadLine().Split();
                string a = valor[0];
                string b = valor[1];
                int qtdA = a.Count(Char.IsDigit);
                int qtdB = b.Count(Char.IsDigit);
                
                if (qtdA > qtdB)
                    a = a.Substring(a.Length - qtdB);
                if (a == b)
                    Console.WriteLine("encaixa");
                else
                    Console.WriteLine("nao encaixa");

            }

    }

}
