using System; 

class URI {

    static void Main(string[] args) { 

        while (true)
        {
            string[] v = Console.ReadLine().Split();
            string d = v[0];
            string n = v[1];
            
                if (d == "0" && n == "0")
                    break;

                else if (!n.Contains(d))
                {
                    //double m = double.Parse(n);
                    Console.WriteLine(n);
                }
                else if (n.Contains(d))
                {
                    string p = n.Replace(d, "");
                    if (string.IsNullOrEmpty(p))
                    Console.WriteLine(0);
                    else if (double.Parse((n.Replace(d, ""))) == 0)
                    Console.WriteLine(0);
                    else
                    Console.WriteLine(n.Replace(d, "").TrimStart(new char[] { '0' }));

                }

        }

    }

}
