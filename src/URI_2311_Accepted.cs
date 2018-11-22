using System;
using System.Linq;
using System.Collections.Generic;

class URI {

    static void Main(string[] args) { 

        int qC = int.Parse(Console.ReadLine());
        for (int i = 0; i < qC; i++)
        {
            string nomeCompetidor = Console.ReadLine();
            double gD = double.Parse(Console.ReadLine());
            string[] notas = Console.ReadLine().Split();
            List<double> arrNotas = new List<double>();
            for (int j = 0; j < notas.Length; j++)
            {
                arrNotas.Add(double.Parse(notas[j]));
            }
            arrNotas.Remove(arrNotas.Min());
            arrNotas.Remove(arrNotas.Max());
            double soma = 0;
            foreach (var item in arrNotas)
            {
                soma += item;
            }
            Console.WriteLine("{0} {1:0.00}", nomeCompetidor, soma*gD);           
            
        }

    }

}
