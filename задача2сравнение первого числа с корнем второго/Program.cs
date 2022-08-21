/*
//Задача2 программа которая проверяет является ли первое число, квадратом второго.
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2 * num2)
    Console.WriteLine($"{num1} является квадратом {num2}");
else
{
    Console.WriteLine($"{num1} не является квадратом {num2}");
}
   

// Задача3 На вход одается число N,на выходе нужно указать все целые число от -N до N.
Console.WriteLine("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = num * (-1);

while(current <= num)
{
    Console.Write(current + " ");
    current++;
}
*/
//задача 4 вводится трехзначное число, нужно вывести последнюю цифру.
Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = num % 10;
Console.WriteLine($" последняя цифра {num} это {result}");
