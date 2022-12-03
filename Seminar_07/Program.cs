Console.Clear();

Console.WriteLine("Введите кол-во строк массива:");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите кол-во столбцов массива:");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArrayRandom(rows, columns, 0, 9);
PrintArray(array);
Console.WriteLine();
// GetDiagonalSum(array, rows, columns);
// GetArrayPowIJ(array, rows, columns);
// GetSortCol(array, rows, columns);
GetAvgSumCol(array, rows, columns);


// ------------------------------ Method ----------------------------------

// Метод создания двумерного массива Random
int[,] GetArrayRandom(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m, n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = new Random().Next(minValue, maxValue+1);
        }
    }
    return result;
}

// Метод печати массива
void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i,j].ToString().PadRight(6));
        }
    Console.WriteLine();
    }
}
void PrintArrayFloat(float[] array){
    for(int i = 0; i < array.Length; i++){
        Console.Write(array[i].ToString().PadRight(6));
    }
}


// Работа с массивом
// Задать двумерный массив и отсортировать нечетные столбцы по возрастанию
void GetSortCol(int[,] result, int m, int n){
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j+=2){
            for (int g = 0; g < m-1 ; g++){
                if (result[g,j] > result[g+1,j]){
                    int temp = result[g,j];
                    result[g,j] = result[g+1,j];
                    result[g+1,j] = temp;
                }
            }
        }
    }
    PrintArray(result);
}


// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.

// int[,] GetArrayIplusJ(int m, int n, int minValue, int maxValue){
//     int[,] result = new int[m, n];
//     for(int i = 0; i < m; i++){
//         for(int j = 0; j < n; j++){
//             result[i,j] = i+j;
//         }
//     }
//     return result;
// }



// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

// void GetArrayPowIJ(int[,] result, int m, int n){
//     for(int i = 0; i < m; i++){
//         for(int j = 0; j < n; j++){
//             if (i % 2 == 0 && j % 2 == 0) result[i, j] = (int)Math.Pow(result[i, j],2);
//             Console.Write(result[i,j].ToString().PadLeft(4));
//         }
//     Console.WriteLine();
//     }
// }



// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// void GetDiagonalSum(int[,] result, int m, int n){
//     int sum = 0;
//     for(int i = 0; i < m; i++){
//         for(int j = 0; j < n; j++){
//             if (i == j) sum += result[i,j];
//         }
//     }
//     Console.WriteLine($"Сумма диагонали (с индексами (0,0); (1;1) и т.д) = {sum}");
// }




void GetAvgSumCol(int[,] result, int m, int n){
    float[] mas = new float[n];
    for(int j = 0; j < n; j++){
        for(int i = 0; i < m; i++){
            mas[j] += result[i,j];
        }
        mas[j] /= (float)n;
    }
    PrintArray(result);
    Console.WriteLine();
    Console.WriteLine("Среднее арифметическое:");
    PrintArrayFloat(mas);
}