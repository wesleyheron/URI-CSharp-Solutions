using System; 

class URI {

    static void Main(string[] args) { 

            string text = "LIFE IS NOT A PROBLEM TO BE SOLVED";
            int n = int.Parse(Console.ReadLine());
            string partOfText;
            partOfText = text.Substring(0, n);
            Console.WriteLine(partOfText);

    }

}
