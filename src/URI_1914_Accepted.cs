using System; 

class URI {

    static void Main(string[] args) { 

        int qt = int.Parse(Console.ReadLine());

            for (int i = 0; i < qt; i++)
            {
                string[] t = Console.ReadLine().Split();
                string t1 = t[0];
                string t2 = t[1];
                string t3 = t[2];
                string t4 = t[3];

                string[] v = Console.ReadLine().Split();
                int v1 = int.Parse(v[0]);
                int v2 = int.Parse(v[1]);

                if(t2 == "PAR")
                {
                    if((v1 + v2) % 2 == 0)
                        Console.WriteLine(t1);
                    else
                        Console.WriteLine(t3);
                }
                else if(t2 == "IMPAR")
                {
                    if ((v1 + v2) % 2 != 0)
                        Console.WriteLine(t1);
                    else
                        Console.WriteLine(t3);
                }                   


            }

    }

}
