// Example01
// Записать программу, которая по заданному номеру четверти, показывает диапозон возможных точек в этой четверти (x и y)

// Console.WriteLine("Введите номер четверти: ");
// int num = int.Parse(Console.ReadLine()!);

// switch (num)
// {
//     case 1:{
//     Console.WriteLine("Это 1-ая четверть!");
//     break;
//     }
//     case 2:{
//     Console.WriteLine("Это 2-ая четверть!");
//     break;
//     }
//     case 3:{
//     Console.WriteLine("Это 3-я четверть!");
//     break;
//     }
//     case 4:{
//     Console.WriteLine("Это 4-ая четверть!");
//     break;
//     }
//     default:{
//         Console.WriteLine("Такой четверти не существует!");
//         break;
//     }
// }


// Example02
// Определить, является ли заданное шестизначное число счастливым.
// (Счастливым называют такое шестизначное число, что сумма его первых трех цифр равна сумме его последних трех цифр).

// Var1

int num = new Random().Next(100000, 1000000);
Console.WriteLine(num);
string numbers = Convert.ToString(num);
int first = Convert.ToInt32(numbers[0]) + Convert.ToInt32(numbers[1]) + Convert.ToInt32(numbers[2]);
int second = Convert.ToInt32(numbers[3]) + Convert.ToInt32(numbers[4]) + Convert.ToInt32(numbers[5]);

if (first == second) Console.WriteLine("Число счастливое!");
else Console.WriteLine("Числго не счастливое!");


// Var2

// int num = new Random().Next(100000, 1000000);

Console.WriteLine("Введите номер четверти: ");
int num = int.Parse(Console.ReadLine()!);
if (num > 99999 && num < 1000000)
{
    Console.WriteLine(num);
    if (((num / 100000) + ((num / 10000) % 10) + (num / 1000) % 10) == ((num / 100) % 10 + (num / 10) % 10 + (num % 10)))
    {
        Console.WriteLine("Число счастливое!");
    }
    else{
        Console.WriteLine("Число не счастливое!");
    }
}
else{
    Console.WriteLine("Число не шестизначное!");
}


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

int[] mas = {3, 6, 2, 1};
// int[] mas = {7, -5, 1, -1};

double masR = Math.Sqrt(Math.Pow(mas[0]-mas[2], 2) + Math.Pow(mas[1]-mas[3], 2));
Console.WriteLine($"{masR:f2}");


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.

// 2 -> 1,4

Console.WriteLine("Введи число:");
int num = int.Parse(Console.ReadLine()!);
if (num < 0)
{
    Console.WriteLine("Число отрицательно преобразовано в положительное");
    num = -num;
}
for (int i = 1; i <= num; i++)
    {
        Console.Write($"{Math.Pow(i, 2)} ");
    }

