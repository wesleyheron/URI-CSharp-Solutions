using System;
class URI
{
    static void Main(string[] args)
    {
        string v;

        while ((v = Console.ReadLine()) != null)
        {
            bool maiuscula = true;
            string sentDanc = string.Empty;
            v = v.ToLower();
            char[] arr = v.ToCharArray();
            for (int i = 0; i < v.Length; i++)
            {
                if (arr[i] == ' ')
                {
                    sentDanc += arr[i];
                    continue;
                }
                if (maiuscula)
                {
                    sentDanc += arr[i].ToString().ToUpper();
                    maiuscula = false;
                }
                else
                {
                    sentDanc += arr[i];
                    maiuscula = true;
                }

            }
            Console.WriteLine(sentDanc);


        }


    }

}
