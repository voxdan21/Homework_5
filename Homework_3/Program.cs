// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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
// метод перемножения крайних чисел
int[] MultiplicationNumbersArray(int[] array)
{
    if (array.Length % 2 == 0)
    {
        int[] returnArray = new int[array.Length / 2];

        for (int i = 0; i < array.Length / 2; i++)
        {
            returnArray[i] = array[i] * array[array.Length - 1 - i];
        }
        return returnArray;
    }
    else
    {
        int[] returnArray = new int[array.Length / 2 + 1];

        for (int i = 0; i <= array.Length / 2; i++)
        {
            if (i == array.Length - 1 - i)
            {
                returnArray[i] = array[i];
            }
            else
            {
                returnArray[i] = array[i] * array[array.Length - 1 - i];
            }
        }
        return returnArray;
    }

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
    int[] multiplicator = MultiplicationNumbersArray(array);
    Console.WriteLine("");
    Console.WriteLine($"Произведение пар чисел в одномерном массиве.:");
    PrintArray(multiplicator);
}  
catch (Exception ex)
{
    Console.WriteLine($"Входное значение имеет неверный формат. Ошибка: {ex.Message}");
}