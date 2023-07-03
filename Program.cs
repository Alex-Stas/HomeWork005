// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int InputIntNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }

// int[] CreateArray(int size)
// {
//     return new int[size];
// }

// void FillArray(int[] array, int min, int max)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.Length; i++)
//         array[i] = rnd.Next(min, max + 1); 
// }


// void PrintArray(int[] array) 
// {
// foreach (int item in array)
// {
// Console.Write($"{item} ");
// }
// Console.WriteLine();
// }

// int OddCounter (int[] array)
// {
//     int oddCounter = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] / 2 * 2 == array[i]) oddCounter += 1; 
//     }
//     return oddCounter;
// }


// int size = InputIntNum("Введите размер массива: ");
// int minValue = 100;
// int maxValue = 999;

// int[] myArray = CreateArray(size);
// FillArray(myArray, minValue, maxValue);
// PrintArray (myArray);
// Console.WriteLine ($"В массиве {OddCounter(myArray)} чётных элементов.");




// ****************************************************************
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int InputIntNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }

// int[] CreateArray(int size)
// {
//     return new int[size];
// }

// void FillArray(int[] array, int min, int max)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.Length; i++)
//         array[i] = rnd.Next(min, max + 1); 
// }


// void PrintArray(int[] array) 
// {
// foreach (int item in array)
// {
// Console.Write($"{item} ");
// }
// Console.WriteLine();
// }

// int EvenElementsSum (int[] array)
// {
//     int evenElementsSum = 0;
//     for (int i = 1; i < array.Length; i += 2) 
//     // 0 позиция, как и в условии считается за четную, если четный по порядку, то нужно начать с i = 0.
//     {
//         evenElementsSum = evenElementsSum + array[i]; 
//     }
//     return evenElementsSum;
// }


// int size = InputIntNum("Введите размер массива: ");
// int minValue = InputIntNum("Введите минимальное значение элемента: ");
// int maxValue = InputIntNum("Введите максимальное значение элемента: ");

// int[] myArray = CreateArray(size);
// FillArray(myArray, minValue, maxValue);
// PrintArray (myArray);
// Console.WriteLine ($"Сумма нечетных элементов массива: {EvenElementsSum(myArray)}");



// ****************************************************************
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int InputIntNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

double InputDoubleNum(string message)
{
    Console.Write(message);
    return double.Parse(Console.ReadLine()!);
}

double[] CreateArray(int size)
{
    return new double[size];
}

void FillArray(double[] array, double min, double max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = min + (Math.Pow(min * min, 0.5) + Math.Pow(max * max, 0.5)) * rnd.NextDouble();

}


void PrintArray(double[] array)
{
    foreach (double item in array)
    {
        Console.Write($"{item:f2} ");
    }
    Console.WriteLine();
}

double FindMax(double[] array)
{
    double max = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

double FindMin(double[] array)
{
    double min = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

int size = InputIntNum("Введите размер массива: ");
double minValue = InputDoubleNum("Введите минимальное значение элемента: ");
double maxValue = InputDoubleNum("Введите максимальное значение элемента: ");

double[] myArray = CreateArray(size);
FillArray(myArray, minValue, maxValue);
PrintArray(myArray);
double max = FindMax(myArray);
double min = FindMin(myArray);
Console.WriteLine($"Разница между максимальным ({max:f2}) и минимальным ({min:f2}) элементом равна {(max-min):f2}");
