using System; 

class URI {

    static void Main(string[] args) { 

        int qt = int.Parse(Console.ReadLine());            
            double total = 0;
            while (qt > 0)
            {
                string[] valores = Console.ReadLine().Split();
                if(int.Parse(valores[0]) == 1001)
                    total += (int.Parse(valores[1]) * 1.50);
                else if (int.Parse(valores[0]) == 1002)
                    total += (int.Parse(valores[1]) * 2.50);
                else if (int.Parse(valores[0]) == 1003)
                    total += (int.Parse(valores[1]) * 3.50);
                else if (int.Parse(valores[0]) == 1004)
                    total += (int.Parse(valores[1]) * 4.50);
                else if (int.Parse(valores[0]) == 1005)
                    total += (int.Parse(valores[1]) * 5.50);
                qt--;
            }
            Console.WriteLine("{0:0.00}", total);

    }

}
