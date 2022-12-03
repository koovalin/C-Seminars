// // 

// int[] array = GetArray(10, 0, 10);
// Console.WriteLine($"[{String.Join(", ", array)}]");

// int[] result = ReverseArray2(array);
// Console.WriteLine($"[{String.Join(", ", result)}]");

// ReverseArray1(array);
// Console.WriteLine($"[{String.Join(", ", array)}]");


// int[] GetArray(int size, int minValue, int maxValue){
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++){
//         array[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return array;
// }

// void ReverseArray1 (int[] array){
//     for(int i = 0; i < array.Length/2; i++){
//         int temp = array[i];
//         array[i] = array[array.Length - i - 1];
//         array[array.Length - i - 1] = temp;
//     }
// }

// int[] ReverseArray2 (int[] array){
//     int[] result = new int[array.Length];
//     for(int i = 0; i < array.Length; i++){
//         result[i] = array[array.Length - i - 1];
//     }
//     return array;
// }





// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.


// int A, B, C;
// Console.WriteLine("Введи сторону А:");
// A = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введи сторону B:");
// B = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введи сторону C:");
// C = int.Parse(Console.ReadLine()!);
// if (Treugol(A, B, C))
//     Console.WriteLine("Такой треугольник существует!");
// else
//     Console.WriteLine("Такой треугольник не существует!");


// bool Treugol(int A, int B, int C)
// {
//     if ((A + B) > C  && (A + C) > B && (C + B) > A)
//         return true;
//     return false;
// }






// // Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// // Делится число на 2 и записываются его остатки с конца в начало


// int num10;
// Console.WriteLine("Введи десятичное число: ");
// num10 = int.Parse(Console.ReadLine()!);



// int From10To2(int num10){

//     while (num10 != 0){
//         int n = num10 / 2;
//         Console.Write(n);
//     }
// }



// **Задача 44:** Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


// int n = 7;
// int first = 0;
// int second = 1;
// Console.Write($"{first} {second}");

// for (int i = 0; i < n-2; i++){
//     int num = 0;
//     num = first + second;
//     Console.Write($" {num}");
//     first = second;
//     second = num;
// }


// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] arr = GetArray(10);

Console.WriteLine($"[{String.Join(", ",arr)}]\n");
CopyArray(arr);

void CopyArray(int[] array){
    int[] copyArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
        copyArray[i] = array[i];
    Console.WriteLine($"[{String.Join(", ",copyArray)}]");
}

int[] GetArray(int size, int minValue = 0, int maxValue = 10){
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue+1);
    return array;
}
