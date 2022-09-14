// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, \
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

//метод создания массива
int[] GetArray(int size, int startValue, int endValue)
{
    var array = new int[size];
    var random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(startValue, endValue + 1);

    }
    return array;
}
// метод вывода массива
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    return;
}

// метод определения четных чисел
int CheckEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

try

{
    Console.WriteLine("Введите размер массива:");
    int size = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите начало отрезка цифр: ");
    int start = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите конец отрезка цифр: ");
    int end = Convert.ToInt32(Console.ReadLine());

    int[] array = GetArray(size, start, end);
    Console.WriteLine($"Наш массив:");
    PrintArray(array);
    Console.WriteLine("");
    int sum = CheckEvenNumbers(array);
    Console.WriteLine($"Количество чётных чисел: {sum}");

}
catch (Exception ex)
{
    Console.WriteLine($"Входное значение имеет неверный формат. Ошибка: {ex.Message}");
}
