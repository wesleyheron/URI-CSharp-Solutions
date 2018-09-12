using System; 

class URI {

    static void Main(string[] args) { 

        string[] v = Console.ReadLine().Split();
            int p = int.Parse(v[0]);
            int j1 = int.Parse(v[1]);
            int j2 = int.Parse(v[2]);
            int r = int.Parse(v[3]);
            int a = int.Parse(v[4]);

            if(p == 1)
            {
                if ((j1 + j2) % 2 == 0)
                {
                    if (r == 0)
                        Console.WriteLine("Jogador 1 ganha!");
                    else if (r == 1 && a == 0)
                        Console.WriteLine("Jogador 1 ganha!");                       
                    else if(r == 1 && a == 1)
                        Console.WriteLine("Jogador 2 ganha!");
                    else if (r == 0 && a == 1)
                        Console.WriteLine("Jogador 1 ganha!");
                }
                else if ((j1 + j2) % 2 != 0)
                {   
                    if(r == 0 && a == 0)
                        Console.WriteLine("Jogador 2 ganha!");                
                    if (r == 1 && a == 0)
                        Console.WriteLine("Jogador 1 ganha!");  
                    else if (r == 1 && a == 1)
                        Console.WriteLine("Jogador 2 ganha!");
                    else if (r == 0 && a == 1)
                        Console.WriteLine("Jogador 1 ganha!");
                }              

            }

            else if (p == 0)
            {
                if ((j1 + j2) % 2 == 0)
                {
                    if (r == 0)
                        Console.WriteLine("Jogador 2 ganha!");
                    else if (r == 1 && a == 0)
                        Console.WriteLine("Jogador 1 ganha!");
                    else if (r == 1 && a == 1)
                        Console.WriteLine("Jogador 2 ganha!");
                    else if (r == 0 && a == 1)
                        Console.WriteLine("Jogador 1 ganha!");
                }
                else if ((j1 + j2) % 2 != 0)
                {
                    if (r == 0 && a == 0)
                        Console.WriteLine("Jogador 1 ganha!");
                    if (r == 1 && a == 0)
                        Console.WriteLine("Jogador 1 ganha!");
                    else if (r == 1 && a == 1)
                        Console.WriteLine("Jogador 2 ganha!");
                    else if (r == 0 && a == 1)
                        Console.WriteLine("Jogador 1 ganha!");
                }
            }

    }

}
