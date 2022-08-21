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
