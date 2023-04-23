// Задайте одномерный массив, заполненный случайными числами (длина массива 5 элементов). 
// Найдите сумму элементов, стоящих на нечётных индексах (индексы с нуля).

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] array = new int[5];

for (int i = 0; i < array.Length; i++)
{
    int randomNumber = new Random().Next(1, 10);
    array[i] = randomNumber;
    Console.Write(array[i] + " ");
    Console.Write(" ");

}
int sumNumbers = array[0] + array[2] + array[4];
Console.WriteLine($"Сумма элементов, стоящих на нечётных индексах: {sumNumbers}");