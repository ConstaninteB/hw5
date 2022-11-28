// Задача 34 Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет
//   количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int [] FillArray(int size)
// {
//     int[] arr = new int[size];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(100, 1000);
//     }
//     return arr;
// }

// Console.Write("Введите длину массива: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] array = FillArray(num);
// Console.WriteLine(string.Join(", ", array));
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//  if (array[i] % 2 == 0)
// count++;
// }
// Console.WriteLine($"[ {string.Join(", ",array)} ] -> {count}");

// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [ 10, 11, 12, 13, 14 ] -> 5

// int [] FillArray(int size)
// {
//     int[] arr = new int[size];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(0, 167);
//     }
//     return arr;
// }

// Console.Write("Введите длину массива: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] array = FillArray(num);
// Console.WriteLine(string.Join(", ", array));
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//  if (array[i]>10 && array[i] < 99)
// count++;
// }
// Console.WriteLine($"{count}");



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях(индексах).

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// int [] FillArray(int size)
// {
//     int[] arr = new int[size];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(0, 11);
//     }
//     return arr;
// }
// Console.Write("Введите длину массива: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] array = FillArray(num);
// Console.WriteLine(string.Join(", ", array));
// int sum = 0;
// for (int i = 0; i < array.Length; i++)
// {
// if(i % 2 != 0)
// {
//  sum+=array[i];
// }
// }

// Console.WriteLine($"[ {string.Join(", ", array)} ] -> {sum}");  


// Задача 38: Задайте массив вещественных(тип double) чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] > max)
        {
            max = numbers[z];
        }
    if (numbers[z] < min)
        {
            min = numbers[z];
        }
}

Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}