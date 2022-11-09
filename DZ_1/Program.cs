// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите число");
int number_1= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int number_2= Convert.ToInt32(Console.ReadLine());


if(number_1>number_2)
{
    Console.WriteLine(number_1);
}
else
{
    Console.WriteLine(number_2);
}

