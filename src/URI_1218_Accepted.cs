using System;
using System.Linq; 

class URI {

    static void Main(string[] args) { 

        string n;
        int cont = 0;
        while ((n = Console.ReadLine()) != null)
        {
            int tam = int.Parse(n);
            
            int qtPar = 0;
            int qtF = 0;
            int qtM = 0;

            string np = Console.ReadLine();
            string[] newArr = System.Text.RegularExpressions.Regex.Split(np, @"[^\d]");
            var num = newArr.ToArray().Where(c => !c.Equals("")).ToArray();
            var chars = np.ToArray().Where(x => Char.IsLetter(Convert.ToChar(x))).ToArray();
            if (cont != 0) Console.WriteLine();

            for (int i = 0; i < num.Length; i++)
            {
                if (int.Parse(num[i]) == tam)
                {
                    qtPar++;
                    if (chars[i] == 'F')
                        qtF++;
                    else
                        qtM++;
                }

            }
            cont++;
            Console.WriteLine("Caso " + cont + ":");
            Console.WriteLine("Pares Iguais: " + qtPar);
            Console.WriteLine("F: " + qtF);
            Console.WriteLine("M: " + qtM);

        }

    }

}
