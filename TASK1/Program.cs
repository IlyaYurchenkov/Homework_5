// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
Console.Clear();
int size = ReadInt("Введите размер массива: ");
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int count = 0;


for (int i = 0; i < numbers.Length; i++)
{
if (numbers[i] %2 == 0)
count = count +1;
else
i= i++;
}

Console.WriteLine($"Количество четных чисел {count}");

void FillArrayRandomNumbers(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(100, 1000);
}
}

void PrintArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
