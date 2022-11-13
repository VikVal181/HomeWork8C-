// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int [,] FellArray(int m, int n) {
    int [,] TmpArray = new int[m, n];
    Random rand = new Random ();   
    
    for (int i = 0; i < m; ++i) {
        for (int j = 0; j < n; ++j) {
            TmpArray[i, j] = rand.Next(-99,100); 
        }
    }

    return TmpArray;
}

int [,] ArraySTringSort(int[,] TmpArray) {
    for (int i = 0; i < TmpArray.GetLength(0); ++i) {
        for (int j = 0; j < TmpArray.GetLength(1); ++j) {
            int Max = TmpArray[i,j];
            int MaxIndex=j;
            for (int k= j+1; k < TmpArray.GetLength(1); ++k){
                if (TmpArray[i,k]>Max) {
                    Max=TmpArray[i,k];
                    MaxIndex=k;
                }
            }
            TmpArray[i,MaxIndex]=TmpArray[i,j];
            TmpArray[i,j]=Max;
        }
    }
    return TmpArray;
}

void PrintArray(int[,] Array) {
    for (int i = 0; i < Array.GetLength(0); ++i) {
        for (int j = 0; j < Array.GetLength(1); ++j) {
            if (j != 0) Console.Write(" ");
            Console.Write($"{Array[i,j]}");
        }
        Console.WriteLine($"");
    }
}

Console.Clear();
Console.WriteLine("Введте размерность массива");
Console.WriteLine("Введте m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введте n:");
int n = Convert.ToInt32(Console.ReadLine());

int[,] Array = FellArray(m, n);
Console.WriteLine("Исходный массив:");
PrintArray(Array);

Console.WriteLine("");

Console.WriteLine("Отсортированный массив:");
Array=ArraySTringSort(Array);
PrintArray(Array);

