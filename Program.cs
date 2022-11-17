//                              ДОМАШНЕЕ ЗАДАНИЕ К СЕМИНАРУ 5

// //ЗАДАЧА 34: Задайте массив, заполненный случайными положительными трехзначными числами. 
// //           Напишите программу, которая покажет количество четных чисел в массиве

// int [] FullArray(int N, int minVal, int maxVal)
// {
//     int [] arr = new int [N];
//     for(int i = 0; i < N; i++)
//     {
//         arr [i] = new Random().Next(minVal, maxVal);
//     }
//     return arr;
// }

// void PrintArray(int [] arr)
// {
//     Console.Write("[");
//     for(int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr [i] + ", ");
//     }
//     Console.WriteLine("\b\b]");
// }

// int SearchEvenArrayElements(int [] arr)
// {
//     int result = 0;
//     for(int i = 0; i < arr.Length; i++)
//     {
//         if(arr [i] % 2 == 0)
//         {
//             result += 1;
//         }
//     }
//     return result;
// }

// int [] newArr = FullArray(12, 100, 1000);
// Console.WriteLine("Number of even array elements: ");
// PrintArray(newArr);
// Console.WriteLine($"equally {SearchEvenArrayElements(newArr)}");

// // ЗАДАЧА 36: Задайте массив, заполненный случайными числами. 
// //            Найдите сумму элементов, стоящих на нечетных позициях

// int [] FullArray(int N, int minVal, int maxVal)
// {
//     int [] arr = new int [N];
//     for(int i = 0; i < arr.Length; i++)
//     {
//         arr [i] = new Random().Next(minVal, maxVal);
//     }
//     return arr;
// }

// void PrintArray(int [] arr)
// {
//     Console.Write("[");
//     for(int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr [i] + ", ");
//     }
//     Console.WriteLine("\b\b]");
// }

// int SumOddPosition(int [] arr)
// {
//     int result = 0;
//     for(int i = 1; i < arr.Length; i += 2)
//     {
//         result += arr [i];
//     }
//     return result;
// }

// int [] newArr = FullArray(12, -12, 12);
// Console.WriteLine("The sum of the elements standing at odd positions of the array");
// PrintArray(newArr);
// Console.WriteLine($"Equal to {SumOddPosition(newArr)}");

// // ЗАДАЧА 38: Задайте массив вещественных чисел. 
// //            Найдите разницу между максимальным и минимальным элементов массива

// double [] FullArray(int N)
// {
//     double [] arr = new double [N];
//     for(int i = 0; i < arr.Length; i++)
//     {
//         arr [i] = Math.Round(new Random().NextDouble(), 1) + new Random().Next(0, 10);
//     }
//     return arr;
// }

// void PrintArray(double [] arr)
// {
//     Console.Write("[");
//     for(int i = 1; i < arr.Length; i++)
//     {
//        Console.Write(arr [i] + "; ");
//     }
//     Console.WriteLine("\b\b]");
// }

// double FindDiffMaxMinArray(double [] arr)
// {
//     double min = arr [0];
//     double max = arr [0];
//     double result = 0;
//     for(int i = 1; i < arr.Length; i++)
//     {
//         if(arr [i] < min) min = arr [i];
//     }
//     for(int j = 1; j < arr.Length; j++)
//     {
//         if(arr [j] > max) max = arr [j];
//     }
//     result = max - min;
//     return result;
// }

// Console.WriteLine("Do you want to set the length of the array yourself? If yes, then enter the word 'Yes'. Otherwise it will be set randomly");
// string check = Console.ReadLine();
// int length;
// if(check == "Yes")
// {
//     Console.WriteLine("Great! Enter any number: ");
//     length = Convert.ToInt32(Console.ReadLine());
// }
// else
// {
//     length = new Random().Next(1, 20);
// }

// double [] newArray = FullArray(length);
// Console.WriteLine("The difference between the maximum and minimum array elements");
// PrintArray(newArray);
// Console.WriteLine($"Equal to: {FindDiffMaxMinArray(newArray)}");

//           Последняя задача из семинара 5. Решил при просмотре в записи

// // ЗАДАЧА 4. Найдите произведение пар чисел в одномерном массиве. 
// //           Парой считаем первый и последний элементы, второй и предпоследний и т.д. 
// //           Результат запишите в новом массиве

// int [] FullArray(int N, int minVal, int maxVal)
// {
//     int [] arr = new int [N];
//     for(int i = 0; i < N; i++)
//     {
//         arr [i] = new Random().Next(minVal, maxVal+1);
//     }
//     return arr;
// }

// void PrintArray(int [] arr)
// {
//    Console.Write("[");
//    for(int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr [i] + ", ");
//     }
//     Console.WriteLine("\b\b]");
// }

// int [] MultiplArrElement(int [] arr)
// {
//     int N2 = 0;
//     if(arr.Length % 2 == 0)
//     {
//         N2 = arr.Length / 2;
//     }
//     else 
//     {
//         N2 = arr.Length / 2 + 1;
//     }
//     int [] multiArr = new int [N2];
//     int j = arr.Length - 1;
   
//     for(int i = 0; i <= j; i++)
//     {
//         if(i == j)
//         {
//             multiArr [i] = arr [i];
//         }
//         else
//         {
//         multiArr [i] = arr [i] * arr [j];
//         j -= 1;
//         }               
//     }
//     return multiArr;
// }

// int [] NewArray = FullArray(10, 1, 10);
// int [] MultiArr = MultiplArrElement(NewArray);
// Console.WriteLine($"The original array: ");
// PrintArray(NewArray);
// Console.WriteLine("Multiplied array: ");
// PrintArray(MultiArr);












// //                                ЗАДАЧИ ИЗ СЕМИНАРА 5

// //ЗАДАЧА 1: Задайте массив из 12 элементов, заполненный случайными числами 
// //          из промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.
// //          Например, в массиве [3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6] 
// //          сумма отрицательных равна -20.

// int [] FullArray(int N, int minVal, int maxVal)
// {
//     int [] arr = new int [N];
//     for(int i = 0; i < N; i++)
//     {
//         arr [i] = new Random().Next(minVal, maxVal + 1);
//     }
//     return arr;
// }

// int SumNegative(int [] arr)
// {
//     int result = 0;
//     for(int i = 0; i < arr.Length; i++)
//     {
//         if(arr[i] < 0)
//         {
//             result += arr[i];
//         }
//     }
//     return result;
// }

// void PrintArr(int [] arr)
// {
//     Console.Write("[");
//     for(int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr [i] + ", ");
//     }
//     Console.Write("\b\b]");
// }

// int [] randArr = FullArray(12, -9, 9); 
// Console.Write($"The sum of the negative values of array: ");
// PrintArr(randArr);
// Console.WriteLine($" is equal to {SumNegative(randArr)}");

// ЗАДАЧА 2: Напишите программу замены элементов массива: положительные элементы 
//           замените на соответствующие отрицательные, и наоборот

// int [] FullArray(int N, int minVal, int maxVal)
// {
//     int [] arr = new int [N];
//     for(int i = 0; i < N; i ++)
//     {
//         arr [i] = new Random().Next(minVal, maxVal + 1);
//     }
//     return arr;
// }

// void PrintArr(int [] arr)
// {
//     Console.Write("[");
//     for(int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr [i] + ", ");
//     }
//     Console.WriteLine("\b\b]");
// }

// // void PrintConvertArr(int [] arr)
// // {
// //     Console.Write("[");
// //     for(int i = 0; i < arr.Length; i++)
// //     {
// //         Console.Write($"{arr [i] = arr [i] * -1}, ");
// //     }
// //     Console.WriteLine("\b\b]");
// // }
//  int [] ConvertArr(int [] arr)
//     {
//         for(int i = 0; i < arr.Length; i++)
//         {
//             arr [i] *= -1;
//         }
//         return arr;
//     }

// int [] randArr = FullArray(20, -50, 50);
// Console.WriteLine("The original array: ");
// PrintArr(randArr);

// Console.WriteLine("The inverted array: ");
// int [] convertArr = ConvertArr(randArr);
// PrintArr(convertArr);

// ЗАДАЧА 3: Задайте массив. Напишите программу, которая определяет, 
//           присутствует ли заданное число в массиве

// int [] FullArray(int N, int minVal, int maxVal)
// {
//     int [] arr = new int [N];
//     for(int i = 0; i < N; i++)
//     {
//         arr [i] = new Random().Next(minVal, maxVal + 1);
//     }
//     return arr;
// }

// void PrintArray(int [] arr)
// {
//     Console.Write("[");
//     for(int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr [i] + ", ");
//     }
//     Console.WriteLine("\b\b]");
// }

// void FindElement(int [] arr, int find)
// {
//     int check = 0;
//     for(int i = 0; i < arr.Length; i++)
//     {
//         if(arr [i] == find) 
//         {
//             Console.WriteLine($"In the array, element {find} is present under index {i}");
//             check = 1; 
//         }
//     }
//     if(check == 0) Console.WriteLine($"The desired element {find} was not found in the array");
// }

// Console.WriteLine("Enter a number to search for");
// int find = Convert.ToInt32(Console.ReadLine());
// int [] creatArr = FullArray(50, 0, 10);
// Console.Write($"Created array: ");
// PrintArray(creatArr);
// FindElement(creatArr, find);

// // ЗАДАЧА 4. Найдите произведение пар чисел в одномерном массиве. 
// //           Парой считаем первый и последний элементы, второй и предпоследний и т.д. 
// //           Результат запишите в новом массиве

// int [] FullArray(int N, int minVal, int maxVal)
// {
//     int [] arr = new int [N];
//     for(int i = 0; i < N; i++)
//     {
//         arr [i] = new Random().Next(minVal, maxVal+1);
//     }
//     return arr;
// }

// void PrintArray(int [] arr)
// {
//    Console.Write("[");
//    for(int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr [i] + ", ");
//     }
//     Console.WriteLine("\b\b]");
// }

// int [] MultiplArrElement(int [] arr)
// {
//     int N2 = 0;
//     if(arr.Length % 2 == 0)
//     {
//         N2 = arr.Length / 2;
//     }
//     else 
//     {
//         N2 = arr.Length / 2 + 1;
//     }
//     int [] multiArr = new int [N2];
//     int j = arr.Length - 1;
   
//     for(int i = 0; i <= j; i++)
//     {
//         if(i == j)
//         {
//             multiArr [i] = arr [i];
//         }
//         else
//         {
//         multiArr [i] = arr [i] * arr [j];
//         j -= 1;
//         }               
//     }
//     return multiArr;
// }

// int [] NewArray = FullArray(10, 1, 10);
// int [] MultiArr = MultiplArrElement(NewArray);
// Console.WriteLine($"The original array: ");
// PrintArray(NewArray);
// Console.WriteLine("Multiplied array: ");
// PrintArray(MultiArr);