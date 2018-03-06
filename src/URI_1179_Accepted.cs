using System; 

class URI {

    static void Main(string[] args) { 

            int[] vetorPar = new int[5];
            int[] vetorImpar = new int[5];
            int contPar = 0, tamanhoArrPar;
            int contImpar = 0, tamanhoArrImpar;

            for (int i = 0; i < 15; i++)
            {
                int valorLido = int.Parse(Console.ReadLine());
                if (valorLido % 2 == 0)
                {
                    vetorPar[contPar] = valorLido;
                    contPar++;
                }

                else
                {
                    vetorImpar[contImpar] = valorLido;
                    contImpar++;
                }
                    

                if (contPar == vetorPar.Length)
                {
                    tamanhoArrPar = 0;
                    while (tamanhoArrPar != 5)
                    {
                        Console.WriteLine("par[{0}] = {1}", tamanhoArrPar, vetorPar[tamanhoArrPar]);
                        tamanhoArrPar++;
                    }                   
                    Array.Clear(vetorPar, 0, vetorPar.Length);
                    contPar = 0;
                }
                if (contImpar == vetorImpar.Length)
                {
                    tamanhoArrImpar = 0;
                    while (tamanhoArrImpar != 5)
                    {
                        Console.WriteLine("impar[{0}] = {1}", tamanhoArrImpar, vetorImpar[tamanhoArrImpar]);
                        tamanhoArrImpar++;
                    }               
                    Array.Clear(vetorImpar, 0, vetorImpar.Length);
                    contImpar = 0;
                }
                if(i == 14)
                {
                    tamanhoArrImpar = 0;
                    while (tamanhoArrImpar < contImpar)
                    {
                        Console.WriteLine("impar[{0}] = {1}", tamanhoArrImpar, vetorImpar[tamanhoArrImpar]);
                        tamanhoArrImpar++;
                    }
                    tamanhoArrPar = 0;
                    while (tamanhoArrPar < contPar)
                    {
                        Console.WriteLine("par[{0}] = {1}", tamanhoArrPar, vetorPar[tamanhoArrPar]);
                        tamanhoArrPar++;
                    }
                }


            }

    }

}