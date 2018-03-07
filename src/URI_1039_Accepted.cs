using System; 

class URI {

    static void Main(string[] args) { 

            string valor;
            int r1, x1, x2, r2, y1, y2;
            double distanciaX;
            double distanciaY;
            double distanciaXY;
            
            while ((valor = Console.ReadLine()) != null)
            {
                string[] valores = valor.Split();
                r1 = int.Parse(valores[0]);
                x1 = int.Parse(valores[1]);
                y1 = int.Parse(valores[2]);
                r2 = int.Parse(valores[3]);
                x2 = int.Parse(valores[4]);
                y2 = int.Parse(valores[5]);

                distanciaX = ((x2 - x1) * (x2 - x1));
                distanciaY = ((y2 - y1) * (y2 - y1));

                distanciaXY = Math.Sqrt(distanciaX + distanciaY);

                if(r1 >= distanciaXY + r2)
                    Console.WriteLine("RICO");
                else
                    Console.WriteLine("MORTO");

            }

    }

}