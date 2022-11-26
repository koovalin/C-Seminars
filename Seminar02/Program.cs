// Напиши программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46

// Первый метод (математический)
// int num = new Random().Next(100, 1000);
// Console.WriteLine(num);
// Console.WriteLine($"Число без второй цифры имеет вид: {num/100}{num%10}");
// int result = (num/100)*10 + num%10;
// Console.WriteLine();
// Console.WriteLine(result);


// // Второй метод (строковый)
// Console.WriteLine("Введите трехзначное число: ");
// string numbers = Console.ReadLine()!;

// if (numbers.Length != 3)
// {
//     Console.WriteLine("Введено неверное число!");
// }
// else
// {
//     Console.WriteLine($"Число без второй цифры имеет вид: {numbers[0]}{numbers[2]}");
// }

// Самостоятельная задача 1
// Вывести случайное число от 10 до 99 и показать наибольшую цифру числа -> 56 -> 6

// int num = new Random().Next(10, 100);
// Console.WriteLine(num);
// int res1 = num / 10;
// int res2 = num % 10;
// int result = res1;
// if (res1 < res2)
// {
//     result = res2;
// }
// Console.WriteLine($"Наибольшая цифра: {result}");


// Самостоятельная задача 2
// 2 числа, кратное ли второе число первому, если нет, выводить отстаток от деления.

int num1 = new Random().Next(1, 10);
Console.WriteLine($"Первое число = {num1}");
int num2 = new Random().Next(10, 100);
Console.WriteLine($"Второе число = {num2} ");
int ost = num1 % num2;

if (ost == 0)
{
    Console.WriteLine("Кратно!");
}
else
{
    Console.WriteLine($"Не кратно! Остаток от деления = {ost}");
}





