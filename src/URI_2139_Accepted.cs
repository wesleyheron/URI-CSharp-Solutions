using System; 

class URI {

    static void Main(string[] args) { 

        string valor;
        DateTime dt = DateTime.Parse("25/12/2016", new System.Globalization.CultureInfo("pt-BR"));
        while ((valor = Console.ReadLine()) != null)
        {
            string[] arr = valor.Split();
            int mes = int.Parse(arr[0]);
            int dia = int.Parse(arr[1]);

            string dataAtual = dia +"/" + mes +"/" + 2016;
            DateTime dtAtual = DateTime.Parse(dataAtual, new System.Globalization.CultureInfo("pt-BR"));

            TimeSpan date = Convert.ToDateTime(dt) - Convert.ToDateTime(dtAtual);
            if(date.Days == 1)
                Console.WriteLine("E vespera de natal!");
            else if(date.Days == 0)
                Console.WriteLine("E natal!");
            else if(date.Days < 0)
                Console.WriteLine("Ja passou!");
            else
                Console.WriteLine("Faltam {0} dias para o natal!", date.Days);           

        }

    }

}
