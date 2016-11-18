using System; 

class URI {

    static void Main(string[] args) { 

            int temp;
            string[] valor = Console.ReadLine().Split();
            int[] arrayList = new int[valor.Length];

            for(int i = 0; i < valor.Length; i++)
            {
                arrayList[i] = Convert.ToInt32(valor[i]);                
            }

            for (int i = 0; i < valor.Length; i++)
            {
                for (int j = 0; j < valor.Length; j++)
                {
                    if (arrayList[i] < arrayList[j])
                    {
                        temp = arrayList[j];
                        arrayList[j] = arrayList[i];
                        arrayList[i] = temp;
                    }
                }
            }
            Console.WriteLine("{0}\n{1}\n{2}\n", arrayList[0], arrayList[1] , arrayList[2]);
            Console.WriteLine("{0}\n{1}\n{2}", valor[0], valor[1], valor[2]);

    }

}