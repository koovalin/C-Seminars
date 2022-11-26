// Однострочный комментарий

/* Многостроынй комментарий
строка 1
Строка 2
строка 3
*/


// Задача 1
// Напишем программу которая на вход принимает число и выдает его квадрат.

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

// int sqr = number * number;

// Console.WriteLine($"Квадрат числа {number} равен {sqr}");

// Вариант 2

// int sqr1 = Convert.ToInt32(Math.Pow(number, 2));
// Console.WriteLine($"Квадрат числа {number} равен {sqr1}");


// Задачка 2

// int rev_number = -number;
// while(rev_number <= number){
//     Console.Write($"{rev_number} ");
//     rev_number ++;
// }


// Задача 3

// int letter3 = number % 10;
// Console.Write($"Третье цифра: {letter3}");


// Задача 4

// Console.WriteLine("Введите первое число: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите второе число: ");
// int b = int.Parse(Console.ReadLine()!);

// if (b == a*a){
//     Console.WriteLine("Да! Является квадратом числа.");
// }
// else{
//     Console.WriteLine("Нет! Не является квадратом числа.");
// }


// Задача 5

if (number == 1) Console.WriteLine("Понедельник");

if (number == 2) Console.WriteLine("Вторник");

if (number == 3) Console.WriteLine("Среда");

if (number == 4) Console.WriteLine("Четверг");

if (number == 5) Console.WriteLine("Пятница");

if (number == 6) Console.WriteLine("Суббота");

if (number == 7) Console.WriteLine("Воскресенье");



