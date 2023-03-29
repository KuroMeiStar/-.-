using System;

class Program
{
    static void Main(string[] args)
    {
        // Ввод массива строк с клавиатуры
        Console.WriteLine("Введите массив строк, разделенных пробелами:");
        string[] arr = Console.ReadLine().Split();

        // Создание нового массива строк длиной не более 3 символов
        string[] new_arr = new string[0];
        foreach (string s in arr)
        {
            if (s.Length <= 3)
            {
                Array.Resize(ref new_arr, new_arr.Length + 1);
                new_arr[new_arr.Length - 1] = s;
            }
        }

        // Вывод нового массива строк
        Console.WriteLine("Массив строк длиной не более 3 символов:");
        foreach (string s in new_arr)
        {
            Console.WriteLine(s);
        }
    }
}
