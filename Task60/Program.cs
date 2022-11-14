// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int [,,] FillArray(int l,int m, int n) {
    int [,,] TmpArray = new int[l, m, n];
    Random rand = new Random ();
    int NewElement=0;   
    for (int i = 0; i < l; ++i) {
        for (int j = 0; j < m; ++j) {
            for (int k = 0; k < n; ++k) {
                bool RepeatFlag=false;
                do{
                    RepeatFlag=false;
                    NewElement=rand.Next(10,100);
                    for (int x = 0; x < l; ++x) {
                        for (int y = 0; y < m; ++y) {
                            for (int z = 0; z < n; ++z) {
                                if (TmpArray[x,y,z]==NewElement) RepeatFlag=true; 
                            }
                        }
                    }
                } while(RepeatFlag==true);
            TmpArray[i, j, k] = NewElement;
            } 
        }
    }

    return TmpArray;
}

void PrintArray(int[,,] Array) {
    for (int i = 0; i < Array.GetLength(0); ++i) {
        for (int j = 0; j < Array.GetLength(1); ++j) {
             for (int k = 0; k < Array.GetLength(2); ++k) {
                if (k != 0) Console.Write(" ");
                Console.Write($"{Array[i,j,k]} ({i},{j},{k})");
        }
        Console.WriteLine($"");
        }
        }
    }

Console.Clear();
Console.WriteLine("Введте размерность массива");
Console.WriteLine("Введте l:");
int l = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введте m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введте n:");
int n = Convert.ToInt32(Console.ReadLine());

int[,,] Array = FillArray(l, m, n);
PrintArray(Array);