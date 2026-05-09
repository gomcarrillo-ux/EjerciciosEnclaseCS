double[] V = { 3, 4, 5, 6, 7 };
double sumaCuadrados = 0;
for (int i = 0; i < V.Length; i++)
        {
          sumaCuadrados += Math.Pow(V[i], 2);
        }
        double magnitud = Math.Sqrt(sumaCuadrados);
        Console.WriteLine($"El vector es: ({string.Join(", ", V)})");
        Console.WriteLine($"La suma de los cuadrados es: {sumaCuadrados}");
        Console.WriteLine($"La magnitud total del vector es: {magnitud:F2}");
