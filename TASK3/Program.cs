// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
Console.Clear();
int size = ReadInt("Введите размер массива: ");
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

int maxNumber = numbers[0];
int minNumber = numbers[0];

for (int i = 1; i < numbers.Length; i++)
  {
    if (maxNumber < numbers[i])
    {
      maxNumber = numbers[i];
    }
        if (minNumber > numbers[i])
    {
      minNumber = numbers[i];
    }
  }

  int difference = maxNumber - minNumber;

Console.WriteLine($"Разность между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {difference}");


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