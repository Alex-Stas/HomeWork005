// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int size)
{
    return new int[size];
}

void FillArray(int[] array, int min, int max)
{
    Random rnd = new Random(); // создание экземпляра класса Random
    for (int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(min, max + 1); // [min, max) полуинтервал
                                           // array[i] = new Random().Next(min, max + 1)
}


void PrintArray(int[] array) 
{
foreach (int item in array)
{
Console.Write($"{item} ");
}
Console.WriteLine();
}

int OddCounter (int[] array)
{
    int oddCounter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] / 2 * 2 == array[i]) oddCounter += 1; 
    }
    return oddCounter;
}


int size = InputNum("Введите размер массива: ");
int minValue = 100;
int maxValue = 999;

int[] myArray = CreateArray(size);
FillArray(myArray, minValue, maxValue);
PrintArray (myArray);
Console.WriteLine ($"В массиве {OddCounter(myArray)} чётных элементов.");




// ****************************************************************
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0





// ****************************************************************
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
