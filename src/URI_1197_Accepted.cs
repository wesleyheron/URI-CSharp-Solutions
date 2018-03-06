using System; 

class URI {

    static void Main(string[] args) { 

            string linha;
            while ((linha = Console.ReadLine()) != null)
            {
                string[] valores = linha.Split();
                int v = int.Parse(valores[0]);
                int t = int.Parse(valores[1]);

                int dobroV = v + v;
                int deslocamento = dobroV * t;
                Console.WriteLine(deslocamento);
            }

    }

}