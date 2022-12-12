class Program
{
    public static void Main()
    {
        // Двумерный массив, поменять первую и последнюю строки массива
        Console.Clear();

        int[,] array = GetArrayRandom(5, 6);
        PrintArray(array);
        Console.WriteLine();

        // 
        //SwapArrayStr(array);

        // Задача 55: Заменить строки на столбцы, вывести предупреждение если это не возможно.
        //ChangeArray(array);

        // Задача 59: Из двумерного массива целых чисел удалить строку и столбец, на пересечении которыъ расположен наименьший массив.
        DeletLinesArray(array);




        // ---------------------- Methods ----------------------

        // Метод удаления значения из массива
        static void DeletLinesArray(int[,] array)
        {
            int m = array.GetLength(0);
            int n = array.GetLength(1);
            int row = 0, col = 0;
            // Нахождение координат первого попавшегося минимального значения
            int min = array[0, 0];
            for (int i = 0; i < m;i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                        row = i;
                        col = j;
                    }
                }
            }

            int[,] result = new int[m-1, n-1];
            for (int i = 0, x = 0; i < m; i++, x++)
            {
                if (i == row)
                {
                    x--;
                    continue;
                }
                for (int j = 0, y = 0; j < n; j++, y++)
                {
                    if (j == col)
                    {
                        y--;
                        continue;
                    }
                    result[x, y] = array[i, j];
                }
            }
            PrintArray(result, "Массив с удаленными строками:");
            Console.WriteLine($"Координаты [{row}, {col}] - {min}");
        }

        // Метод замены строк на столбцы
        static void ChangeArray(int[,] result)
        {
            int m = result.GetLength(0);
            int n = result.GetLength(1);
            if (m != n)
            {
                Console.WriteLine("Массив невозможно изменить!");
            }
            else
            {
                for (int i = 0; i < m; i++)
                {
                    for (int j = i; j < n; j++)
                    {
                        int temp = result[i, j];
                        result[i, j] = result[j, i];
                        result[j, i] = temp;
                    }
                }
                PrintArray(result, "Измененный массив");
            }
        }
        
        // Метод замены строк в двумерном массиве
        static void SwapArrayStr(int[,] result)
        {
            int m = result.GetLength(0);
            int n = result.GetLength(1);
            for (int i = 0; i < n; i++)
            {
                int temp = result[0, i];
                result[0, i] = result[m - 1, i];
                result[m - 1, i] = temp;
            }
            PrintArray(result, "Измененный массив:");
        }



        // Метод создания массива со случайными значениями
        static int[,] GetArrayRandom(int m, int n, int minValue = 0, int maxValue = 20)
        {
            int[,] array = new int[m, n];
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = new Random().Next(minValue, maxValue + 1);
                }
            return array;
        }

        // Метод печати массива
        static void PrintArray(int[,] array, string str = "Массив:")
        {
            Console.WriteLine(str);
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j].ToString().PadRight(6));
                }
                Console.WriteLine();
            }
        }

        Console.ReadLine();
    }
}