using System; 

class URI {

    static void Main(string[] args) { 

            int a, b, c, maiorAB, maiorABC;
            string[] items = Console.ReadLine().Split();

            a = Convert.ToInt32(items[0]);
            b = Convert.ToInt32(items[1]);
            c = Convert.ToInt32(items[2]);

            maiorAB = (a + b + Math.Abs(a - b)) / 2;
            maiorABC = ((c + maiorAB) + Math.Abs(maiorAB - c)) / 2;

            Console.WriteLine("{0} eh o maior", maiorABC);

    }

}