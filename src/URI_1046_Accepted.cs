using System; 

class URI {

    static void Main(string[] args) { 

            int i, f, h;
            string[] hihf = Console.ReadLine().Split();
            i = Convert.ToInt32(hihf[0]);
            f = Convert.ToInt32(hihf[1]);
            h = f - i;
            if(h < 0)
                h = 24 + (f - i);
            if(f == i)
                Console.WriteLine("O JOGO DUROU 24 HORA(S)");
            else
                Console.WriteLine("O JOGO DUROU {0} HORA(S)", h);

    }

}