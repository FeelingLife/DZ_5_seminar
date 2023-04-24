// Задайте массив из 8 случайных чисел из промежутка [-9, 9]. 
// Напишите программу получает на вход число и определяет, присутствует ли заданное число в массиве.

// 4; массив [6, 7, 19, 345, 3] -> нет

// 3; массив [6, 7, 19, 345, 3] -> да

int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
{
    int randomNumber = new Random().Next(-9, 9);
    array[i] = randomNumber;
    Console.Write(array[i] + " ");
    Console.Write(" ");
}

int Check(int x)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (x == array[i])
        {
            Console.Write("- Да ");
            break;
        }
        if (i == 7)
        {
            Console.Write("- Нет ");
        }
    }
    return x;
}

int y = Check(2);


