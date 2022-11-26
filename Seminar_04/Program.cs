namespace Seminar04
{
    class Program
    {
        static void main(String[] args)
        {
            static void Program1(String[] args)
            {
                // Напишите программу, которая принимает на вход чило (А) и выдает сумму числа от 1 до А.

                // Console.WriteLine("Введите число: ");
                // int A = int.Parse(Console.ReadLine()!);
                // Console.WriteLine($"Сумма чисел от 1 до {A} будет равна {GetSum(A)}");
                // 
                // //--------------Методы--------------
                // 
                // int GetSum(int limit)
                // {
                //     int sum = 0;
                //     for (int i = 1; i <= limit; i++)
                //     {
                //         sum += i;
                //     }
                //     return sum;
                // }
            }


            // **Задача 26:**

            // Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

            // 456 -> 3

            // 78 -> 2

            // 89126 -> 5


            // Console.WriteLine("Введи число: ");
            // int number = int.Parse(Console.ReadLine()!);
            // Console.WriteLine($"Знаков - {GetLength(number)} ");


            // // Metod
            // // int GetLength(int num){
            // //     int length = Convert.ToString(num).Length;
            // // }

            // int GetLength(int num){
            //     int c = 0;
            //     while(num > 0){
            //     c++;
            //     num = num / 10;
            //     }
            //     return c;
            // }





            // **Задача 30:**

            // Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

            // [1,0,1,1,0,1,0,0]

            // Console.WriteLine("Длинна массива: ");
            // int size = int.Parse(Console.ReadLine()!);

            // int[] arr = new int[size];
            // for (int i = 0; i < size; i++)
            //     {
            //         arr[i] = new Random().Next(2);
            //     }

            // Console.Write($"{String.Join(",", arr)}");




            // Задача 28:
            // Найти произведение всех элементов массива целых чисел, меньших заданного числа.
            // Размерность массива – 10. Заполнение массива осуществить случайными числами от 50 до 100.


            int[] arraySize = FillArray(10);
            Console.WriteLine($"{String.Join(",", arraySize)}");
            Console.WriteLine("Введите число:");
            int num = int.Parse(Console.ReadLine()!);
            Console.Write($"{SumArray(arraySize, num)}");


            int SumArray(int[] array, int num)
            {
                int sum = 1;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < num)
                        sum *= array[i];
                }
                return sum;
            }

            int[] FillArray(int size)
            {
                int[] array = new int[size];
                for (int i = 0; i < size; i++)
                {
                    array[i] = new Random().Next(50, 101);
                }
                return array;
            }


            Console.ReadKey();
        }
    }
}