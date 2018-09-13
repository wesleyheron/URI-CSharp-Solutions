using System; 

class URI {

    static void Main(string[] args) { 

        int qt = int.Parse(Console.ReadLine());
            int cont2 = 0, cont3 = 0, cont4 = 0, cont5 = 0;            
            string[] n = Console.ReadLine().Split();
            for (int j = 0; j < n.Length; j++)
            {
                int v = int.Parse(n[j]);
                if (v % 2 == 0)
                    cont2++;
                if (v % 3 == 0)
                    cont3++;
                if (v % 4 == 0)
                    cont4++;
                if (v % 5 == 0)
                    cont5++;

            }
            Console.WriteLine("{0} Multiplo(s) de 2", cont2);
            Console.WriteLine("{0} Multiplo(s) de 3", cont3);
            Console.WriteLine("{0} Multiplo(s) de 4", cont4);
            Console.WriteLine("{0} Multiplo(s) de 5", cont5);

    }

}
