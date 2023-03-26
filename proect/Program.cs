/* Задача:

   Написать программу, которая из имеющегося массива строк сформирует массив строк
   длинна которых меньше либо равна 3 символа. 
   Первоначальный массив можно ввести с клавиатуры, либо задать на страте выполнения алгоритма. 
   При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

string[] FillArray(int length)
{
    string[] resultArray = new string[length];

    for (int i = 0; i < length; i++)
    {
        System.Console.Write($"Укажите значение {i + 1}  строки: ");
        resultArray[i] = System.Console.ReadLine();
        System.Console.WriteLine();
    }

    return resultArray;
}

void ShowArray(string[] array)
{
    //Вывод с помощью foreach
    foreach (var elem in array)
    {
        Console.Write("{0} ", elem);
    }

    Console.WriteLine();
}

string[] FilterArray(string[] array, int count)
{
    int length = array.Length;
    int targetCount = 0;
    string[] tempArray = new string[length];

    for (int i = 0; i < length; i++)
    {
        if (array[i].Length <= count)
        {
            tempArray[targetCount] = array[i];
            targetCount++;
        }
    }

    string[] resultArray = new string[targetCount];

    for (int i = 0; i < targetCount; i++)
    {
        resultArray[i] = tempArray[i];
    }

    return resultArray;
}

Console.Write("Введите длинну массива: ");
int length = int.Parse(Console.ReadLine());

string[] array = FillArray(length);
ShowArray(array);

Console.Write("Введите длинну строки для отбора: ");
int count = int.Parse(Console.ReadLine());

string[] resultArray = FilterArray(array,count);
ShowArray(resultArray);