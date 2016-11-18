using System; 

class URI {

    static void Main(string[] args) { 

            string grupo = Console.ReadLine();
            string subGrupo = Console.ReadLine();
            string ordem = Console.ReadLine();

            switch (grupo)
            {
                case "vertebrado":
                    if(subGrupo == "ave")
                    {
                        if(ordem == "carnivoro")
                            Console.WriteLine("aguia");
                        else
                            Console.WriteLine("pomba");
                    }
                    else
                    {
                        if(subGrupo == "mamifero")
                        {
                            if(ordem == "onivoro")
                                Console.WriteLine("homem");
                            else
                                Console.WriteLine("vaca");
                        }
                    }
                    break;

                case "invertebrado":
                    if (subGrupo == "inseto")
                    {
                        if (ordem == "hematofago")
                            Console.WriteLine("pulga");
                        else
                            Console.WriteLine("lagarta");
                    }
                    else
                    {
                        if (subGrupo == "anelideo")
                        {
                            if (ordem == "hematofago")
                                Console.WriteLine("sanguessuga");
                            else
                                Console.WriteLine("minhoca");
                        }
                    }
                    break;
                default:
                    break;
            }

    }

}