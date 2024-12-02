using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        string text = "Это пример текста. Текст должен быть проанализирован. Это важно.";

        // вывожу результат подсчёта частоты слов
        foreach (var item in WordFrequency(text))
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }

    /// <summary>
    static Dictionary<string, int> WordFrequency(string text)
    {
        // убираем знаки препинания
        var words = text
            .ToLower()
            .Split(new[] { ' ', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries); // убираю знаки препинания и пустые строки

        
        return words
            .GroupBy(word => word) // группируем
            .ToDictionary(group => group.Key, group => group.Count()); // преобразуем в словарь где слово - количество
    }
}