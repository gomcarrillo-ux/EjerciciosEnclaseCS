// 1. Crear dos arreglos con los valores indicados
int[] vector1 = { 1, 2, 3, 4, 5 };
int[] vector2 = { 5, 4, 3, 2, 1 };
int productoEscalar = 0;
for (int i = 0; i < vector1.Length; i++)
{
int multiplicacion = vector1[i] * vector2[i];
productoEscalar += multiplicacion;
}
Console.WriteLine($"El producto escalar total es: {productoEscalar}");
