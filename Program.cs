// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// Console.Clear();
// Console.Write("Введите число : ");
// int A = int.Parse(Console.ReadLine());
// Console.Write("Введите степень : ");
// int B = int.Parse(Console.ReadLine());

// Console.WriteLine($"{A} в степень {B} = {Pow(A,B)}");

// int Pow(int num, int rank)
// {
//     if(B==0) return 1;

//     int result = num;
//     for (int i = 2; i <= rank; i++)
//     {
//         result *= num;
//     }
//     return result;
// }

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Clear();
// Console.Write("Введите число : ");
// int num = int.Parse(Console.ReadLine());

// Console.WriteLine($"Сумма цифр = {GetSumNums(num)}");


// int GetSumNums(int number)
// {
//     int sum = 0;
//     while (number>0)
//     {
//         sum += number%10;
//         number /=10;
//     }
//     return sum;
// }


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


// Console.Clear();
// int[] array = GetRandomArray(8,0,100);
// Console.WriteLine($"[{String.Join(",", array)}]");

// int[] GetRandomArray(int size,int minValue,int maxValue)
// {
//     int[] result= new int[size];
//     for (int i = 0 ; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue,maxValue);
//     }
//     return result;
// }

