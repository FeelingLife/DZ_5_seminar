// Задайте массив заполненный случайными положительными трёхзначными числами (длина массива 5 элементов). 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] array = new int[5];
int sumNumbers = 0;

for (int i = 0; i < array.Length; i++)
{
    int randomNumber = new Random().Next(100, 1000);
    array[i] = randomNumber;
    Console.Write(array[i] + " ");
    Console.WriteLine(" ");
}

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            sumNumbers = sumNumbers + 1;
        }
    }
    Console.WriteLine($"Количество четных чисел: {sumNumbers}");