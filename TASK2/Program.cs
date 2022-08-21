// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
Console.Clear();
int size = ReadInt("Введите размер массива: ");
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (i % 2 != 0)
    sum = sum + numbers [i];
    else
    i = i++;
}

Console.WriteLine($"Сумма чисел на нечетных позициях массива {sum}");

void FillArrayRandomNumbers(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(1, 10);
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