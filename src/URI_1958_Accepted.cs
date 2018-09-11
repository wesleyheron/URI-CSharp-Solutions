using System; 

class URI {

    static void Main(string[] args) { 

        string n = Console.ReadLine();
            double nd = double.Parse(n);
            char[] arr = nd.ToString("0.0000E+00").ToCharArray();
            if (n == "-0")
                Console.WriteLine("-{0}", nd.ToString("0.0000E+00"));
            else if (arr[0] != '-')
                Console.WriteLine("+{0}", nd.ToString("0.0000E+00"));            
            else
                Console.WriteLine("{0}", nd.ToString("0.0000E+00"));

    }

}
