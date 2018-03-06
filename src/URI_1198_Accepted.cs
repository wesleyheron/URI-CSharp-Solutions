using System; 

class URI {

    static void Main(string[] args) { 

            string linha;
            while ((linha = Console.ReadLine()) != null)
            {
                string[] valores = linha.Split();
                long soldadosHashmat = long.Parse(valores[0]);
                long soldadosOponente = long.Parse(valores[1]);
                long diferenca;
                if(soldadosHashmat < soldadosOponente)
                {
                    diferenca = soldadosOponente - soldadosHashmat;
                }
                else
                {
                    diferenca = soldadosHashmat - soldadosOponente;
                }                
                Console.WriteLine(diferenca);
            }

    }

}