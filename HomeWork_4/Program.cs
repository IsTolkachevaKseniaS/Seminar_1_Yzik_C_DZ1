// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

// Console.WriteLine("Введите число");
// int A = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите число");
// int B = int.Parse(Console.ReadLine());

// double num =Math.Pow(A,B);

// Console.WriteLine($"Ответ {num}");

// Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите число");

// int num = int.Parse(Console.ReadLine());

// int len = NumberLen(num);
// SumNumbers(num, len);


// // Функция ввода
// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// // Функция подсчета цифр в числе
// int NumberLen(int a)
// {
//     int index = 0;
//     while (a > 0)
//     {
//         a /= 10;
//         index++;
//     }
//     return index;
// }

// // Функция вывода суммы цифр в числе
// void SumNumbers(int n, int len)
// {
//     int sum = 0;
//     for (int i = 1; i <= len; i++)
//     {
//         sum += n % 10;
//         n /= 10;
//     }
//     Console.WriteLine(sum);
// }

// Напишите программу, которая задаёт массив из 8 
// элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int [] array = GetArray(8);
int [] GetArray (int size)
{
   int [] array= new int[size];

   for(int i=0; i<size; i++)
   {
    array[i]= new Random().Next(0,100);
   }
   return array;
}

Console.WriteLine (String.Join("," , array));