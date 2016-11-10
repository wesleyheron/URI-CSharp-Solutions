using System; 

class URI {

    static void Main(string[] args) { 

            int idadeEmDias, iAnos, iMeses, iDias;

            idadeEmDias = Convert.ToInt32(Console.ReadLine());

            iAnos = (idadeEmDias / 365);

            iMeses = (idadeEmDias % 365) / 30;

            iDias = (idadeEmDias % 365) % 30;

            Console.WriteLine("{0} ano(s)", iAnos);
            Console.WriteLine("{0} mes(es)", iMeses);
            Console.WriteLine("{0} dia(s)", iDias);

    }

}