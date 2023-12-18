using System;

int[,] matriz = new int[10, 10];

int valor = 100;


for (int fila = 0; fila < 10; fila++)
{
    for (int columna = 0; columna < 10; columna++)
    {
        matriz[fila, columna] = valor--;
    }
}


for (int fila = 0; fila < 10; fila++)
{
    for (int columna = 0; columna < 10; columna++)
    {
        Console.WriteLine(matriz[fila, columna]);
    }
    Console.WriteLine();
}
for(int fila = 1;fila < 100; fila++)
{
    Console.WriteLine(fila);
}




