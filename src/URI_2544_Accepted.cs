using System; 

class URI {

    static void Main(string[] args) { 

        string n;
        while ((n = Console.ReadLine()) != null)
        {            
            Console.WriteLine(Math.Log(int.Parse(n), 2));
        }

    }

}
