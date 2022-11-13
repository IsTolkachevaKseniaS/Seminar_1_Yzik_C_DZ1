// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите чиcло");

string num= Console.ReadLine(); 

int d = num.Length;

// int num = new Random().Next(10000,100000);
// Console.WriteLine(num);

if(num[5]==num[1] && num[4]==num[2])
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}


// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// Console.WriteLine("Введите число");
// int X1= int.Parse(Console.ReadLine());

// Console.WriteLine("Введите число");
// int Y1= int.Parse(Console.ReadLine());

// Console.WriteLine("Введите число");
// int U1= int.Parse(Console.ReadLine());

// Console.WriteLine("Введите число");
// int X2= int.Parse(Console.ReadLine());

// Console.WriteLine("Введите число");
// int Y2= int.Parse(Console.ReadLine());

// Console.WriteLine("Введите число");
// int U2= int.Parse(Console.ReadLine());

// Console.WriteLine("Введите число");
// int X3= int.Parse(Console.ReadLine());

// Console.WriteLine("Введите число");
// int Y3= int.Parse(Console.ReadLine());

// Console.WriteLine("Введите число");
// int U3= int.Parse(Console.ReadLine());

// double d= Math.Sqrt(Math.Pow(X1-X2,2) +Math.Pow(Y1-Y2,2)+Math.Pow(U1-U2,2));

// Console.WriteLine(d);

// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Введите число");

// int N = int.Parse(Console.ReadLine());


// for (int m=1;m <= N; m++)
// {
//     double num =Math.Pow(m,3);
//     Console.WriteLine(num);
// }
