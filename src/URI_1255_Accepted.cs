using System; 
using System.Linq;

class URI {

    static void Main(string[] args) { 

        int qt = int.Parse(Console.ReadLine());
        string texto = string.Empty;
        char[] arr;
        for (int i = 0; i < qt; i++)
        {
            string res = string.Empty;
            texto = Console.ReadLine().ToLower().Replace(" ", string.Empty);
            string newTexto = new String(texto.Where(c => (c >= 'a' && c <= 'z')).ToArray());
            arr = newTexto.ToCharArray().Distinct().ToArray();
            Array.Sort(arr);
            int maior = 0;
            
            for (int j = 0; j < arr.Length; j++)
            {
                if (maior < newTexto.Count(cc => cc == arr[j]))
                    maior = newTexto.Count(cc => cc == arr[j]);                
            }
            
            for (int k = 0; k < arr.Length; k++)
            {
                if (maior == newTexto.Count(cc => cc == arr[k]))
                    res += arr[k];
            }
            
            Console.WriteLine("{0}", res);
            
        }

    }

}
