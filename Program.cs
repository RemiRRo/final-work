using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите элементы массива, разделяя их пробелом:");
        string input = Console.ReadLine();
        string[] originalArray = input.Split(' ');
        
        string[] newArray = FilterArray(originalArray);
        
        Console.WriteLine("Исходный массив: ");
        PrintArray(originalArray);
        
        Console.WriteLine("\nМассив с элементами длиной <= 3 символов: ");
        PrintArray(newArray);
    }
    
    static string[] FilterArray(string[] originalArray)
    {
        int count = 0;
        foreach (string element in originalArray)
        {
            if (element.Length <= 3)
            {
                count++;
            }
        }
        
        string[] newArray = new string[count];
        int index = 0;
        foreach (string element in originalArray)
        {
            if (element.Length <= 3)
            {
                newArray[index] = element;
                index++;
            }
        }
        
        return newArray;
    }
    
    static void PrintArray(string[] array)
    {
        foreach (string element in array)
        {
            Console.WriteLine(element);
        }
    }
}