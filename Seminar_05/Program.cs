namespace Seminar05
{
    class Program
    {
        static void Main(string[] args)
        {

            // Задача 31: Задайте массив из 12 элементов 

            // int[] array = GetArray(12, -9, 9);
            // Console.WriteLine($"[{String.Join(",", array)}]");
            // int positivSum = 0;
            // int negativSum = 0;

            // foreach (int i in array){
            //     if(i < 0) positivSum += i;
            //     else negativSum += i;
            // }

            // Console.WriteLine($"Сумма положительных = {positivSum} сумма отрицательных = {negativSum}");


            // // ---------------------------- Method ------------------------------------

            // int[] GetArray(int size, int minValue, int maxValue){
            //     int[] result = new int[size];
            //     for(int i = 0; i < size; i++)
            //         result[i] = new Random().Next(minValue, maxValue + 1);
            //     return result;
            // }




            // **Задача 32:** Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
            // [-4, -8, 8, 2] -> [4, 8, -8, -2]

            int[] mas = GetArray(4, -9, 9);
            Console.WriteLine($"[{String.Join(", ", mas)}]");
            Console.WriteLine($"[{String.Join(", ", MirrorArray(mas))}]");

            int[] MirrorArray(int[] array){
                for (int i = 0; i < array.Length; i++) array[i] = -array[i];
                return array;
            }

            int[] GetArray(int size, int min, int max){
                int[] array = new int[size];
                for (int i = 0; i < size; i++)
                    array[i] = new Random().Next(min, max + 1);
                return array;
            }


            // **Задача 33:** Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
            // 4; массив [6, 7, 19, 345, 3] -> нет
            // 3; массив [6, 7, 19, 345, 3] -> да

            // int[] massiv = new int[] {6, 7, 19, 345, 3};

            // Console.WriteLine("Введи число для проверки в массиве:");
            // int n = int.Parse(Console.ReadLine()!);

            // if (FindNumber(massiv, n))
            //     Console.WriteLine($"Число {n} присутствует в массиве!");
            // else
            //     Console.WriteLine($"Число {n} не присутствует в массиве!");

            // bool FindNumber(int[] mus, int num){
            //     foreach (int i in mus){
            //         if (i == num){
            //             return true;
            //         }
            //     }
            //     return false;
            // }


            // Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

            // int[] array = GetArray(123);
            // Console.WriteLine($"[{String.Join(", ", array)}]");
            // Console.WriteLine($"В массиве найдено {Counter(array)} элементов в отрезке [10,99]");


            // int[] GetArray(int num, int r = 1000){
            //     int[] mas = new int[num];
            //     for (int i = 0; i < mas.Length; i++)
            //     {
            //         mas[i] = new Random().Next(r);
            //     }
            //     return mas;
            // }

            // int Counter(int[] mas, int n = 9, int m = 100){
            //     int count = 0;
            //     foreach (int i in mas)
            //     {
            //         if (i < m && i > n)
            //         {
            //             count ++;
            //         }
            //     }
            //     return count;
            // }

            Console.ReadKey();
        }
    }
}