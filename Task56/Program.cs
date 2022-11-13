// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int[] FindSumString(int[,] TmpArray) {
    int[] SumArray = new int[TmpArray.GetLength(0)];
    for (int i = 0; i < TmpArray.GetLength(0); ++i) {
        int Sum=0;
        for (int j = 0; j < TmpArray.GetLength(1); ++j) {
            Sum = Sum + TmpArray[i,j];
        }
        SumArray[i] = Sum;
    }
    return SumArray;
}

int FindIndexMin(int[] Array) {
    int MinIndex = 0;
        for (int i = 1; i < Array.GetLength(0); ++i) {
            if (Array[MinIndex] > Array[i]) MinIndex=i;
        }
    return MinIndex;
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


int []ArraySum=FindSumString(Array);
int IndexMin=FindIndexMin(ArraySum);
Console.WriteLine($"Строка с наименьшей суммой элементов: {IndexMin+1}");
