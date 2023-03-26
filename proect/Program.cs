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
