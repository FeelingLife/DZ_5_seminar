// Задайте массив вещественных чисел от -100 до 100 (длина массива 5 элементов). 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] array = new int[5];

for (int i = 0; i < array.Length; i++)
{
    int randomNumber = new Random().Next(-100, 101);
    array[i] = randomNumber;
    Console.Write(array[i] + " ");
    Console.WriteLine(" ");
}

int maxNumber = array[1];
int minNumber = array[1];
for (int j = 0; j < array.Length; j++)
{
    if (maxNumber > array[j])
    {

    }
    else
    {
        maxNumber = array[j];
    }
}

for (int j = 0; j < array.Length; j++)
{
    if (minNumber < array[j])
    {

    }
    else
    {
        minNumber = array[j];
    }
}
int sumNumber = maxNumber - minNumber;
Console.WriteLine($"Максимальное число: {maxNumber}");
Console.WriteLine($"Минимальное число: {minNumber}");
Console.WriteLine($"Разность максимального числа и минимального числа: ({maxNumber}) - ({minNumber}) = {sumNumber} ");