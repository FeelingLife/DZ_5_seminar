// Задайте массив из 10 случайных чисел из промежутка [-100, 100]. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

// Пример для массива из 5, а не 10 элементов. В своём решении сделайте для 10

// [5, 18, 123, 6, 2] -> 1

// [1, 2, 3, 6, 2] -> 0

// [10, 11, 12, 13, 14] -> 5

int[] array = new int[10];

for (int i = 0; i < array.Length; i++)
{
    int randomNumber = new Random().Next(-100, 100);
    array[i] = randomNumber;
    Console.Write(array[i] + " ");
    Console.Write(" ");
}

Console.WriteLine(" ");
int Check(int x)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 10 && array[i] < 99)
        {
            x = x + 1;
        }
    }
    return x;
}

int y = Check(0);
Console.WriteLine($"Количество чисел: {y}");
