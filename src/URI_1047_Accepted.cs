using System; 

class URI {

    static void Main(string[] args) { 

            int hi, mi, hf, mf, dh, dm;
            string[] hihf = Console.ReadLine().Split();
            hi = Convert.ToInt32(hihf[0]);
            mi = Convert.ToInt32(hihf[1]);
            hf = Convert.ToInt32(hihf[2]);
            mf = Convert.ToInt32(hihf[3]);

            dh = hf - hi;
            if (dh < 0)
            {
                dh = 24 + (hf - hi);
            }
                
            dm = mf - mi;
            if (dm < 0)
            {
                dm = 60 + (mf - mi);
                dh--;
            }
            if(hf == hi && mf == mi)
                Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
            else
                Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", dh, dm);

    }

}