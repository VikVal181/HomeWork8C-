// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int [,] FillArray(int m, int n) {
    int [,] TmpArray = new int[m, n];
    Random rand = new Random ();   
    
    for (int i = 0; i < m; ++i) {
        for (int j = 0; j < n; ++j) {
            TmpArray[i, j] = rand.Next(-9,10); 
        }
    }

    return TmpArray;
}

int [,] MatrixProduct(int[,] MatrixA, int[,] MatrixB) {
    int [,] MatrixProduct = new int[MatrixA.GetLength(0), MatrixB.GetLength(1)];    
    for (int i = 0; i < MatrixA.GetLength(0); ++i) {
        for (int j = 0; j < MatrixB.GetLength(1); ++j) {
        int SumElement=0;
            for (int k = 0; k < MatrixA.GetLength(1); ++k) {
                SumElement=SumElement+MatrixA[i,k]*MatrixB[k,j];
             }
        MatrixProduct[i, j] = SumElement; 
        }
    }
    return MatrixProduct;
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
Console.WriteLine("Введте размерность первой матрицы");
Console.WriteLine("Введте m:");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введте n:");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введте размерность второй матрицы");
Console.WriteLine("Введте m:");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введте n:");
int n2 = Convert.ToInt32(Console.ReadLine());

int[,] Matrix1 = FillArray(m1, n1);
Console.WriteLine("Первая матрица:");
PrintArray(Matrix1);
int[,] Matrix2 = FillArray(m2, n2);
Console.WriteLine("Вторая матрица:");
PrintArray(Matrix2);
if (n1!=m2)
Console.WriteLine("Число столбцов первой матрицы должно быть равно числу строк второй. Умножение невозможно.");
else{
int[,] ResultMatrix=MatrixProduct(Matrix1,Matrix2);
Console.WriteLine("Произведение:");
PrintArray(ResultMatrix);
}

