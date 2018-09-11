using System; 

class URI {

    static void Main(string[] args) { 

        int n = int.Parse(Console.ReadLine());
            Console.WriteLine(ArabicToRoman(n));

    }
    private static string ArabicToRoman(int arabic)
        {
            string[] ThouLetters = { "", "M", "MM", "MMM" };
            string[] HundLetters = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] TensLetters = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] OnesLetters = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            
            string result = "";
            
            int num;
            num = arabic / 1000;
            result += ThouLetters[num];
            arabic %= 1000;
           
            num = arabic / 100;
            result += HundLetters[num];
            arabic %= 100;
           
            num = arabic / 10;
            result += TensLetters[num];
            arabic %= 10;
            
            result += OnesLetters[arabic];

            return result;
        }

}
