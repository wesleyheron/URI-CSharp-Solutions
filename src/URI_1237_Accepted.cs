using System;

class URI
{
    static void Main(string[] args)
    {
        string v1, v2;

        while ((v1 = Console.ReadLine()) != null && (v2 = Console.ReadLine()) != null)
        {
            if (v1.Length < 1 || v2.Length < 1)
                break;           
            Console.WriteLine("{0}", FindMaxCommonSubstring(v1, v2));

        }


    }
    public static int FindMaxCommonSubstring(string s1, string s2)
    {
        int[,] a = new int[s1.Length + 1, s2.Length + 1];
        int row = 0;    
        int col = 0;    

        for (var i = 0; i < s1.Length; i++)
            for (var j = 0; j < s2.Length; j++)
                if (s1[i] == s2[j])
                {
                    int len = a[i + 1, j + 1] = a[i, j] + 1;
                    if (len > a[row, col])
                    {
                        row = i + 1;
                        col = j + 1;
                    }
                }

        return s1.Substring(row - a[row, col], a[row, col]).Length;
    }

}
