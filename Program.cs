using System;
using System.Collections.Generic;

class HashTable<TKey, TValue>
{
    private Dictionary<TKey, TValue> dictionary = new Dictionary<TKey, TValue>();

    public void Add(TKey key, TValue value)
    {
        dictionary[key] = value;
    }

    public bool TryGetValue(TKey key, out TValue value)
    {
        return dictionary.TryGetValue(key, out value);
    }

    public bool Remove(TKey key)
    {
        return dictionary.Remove(key);
    }

    public int Count
    {
        get { return dictionary.Count; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        HashTable<string, int> table = new HashTable<string, int>();

        table.Add("Раз", 1);
        table.Add("Двас", 2);
        table.Add("Трис", 3);

        Console.WriteLine("Считай, громко при чём: " + table.Count);

        int value;
        if (table.TryGetValue("Двас", out value))
        {
            Console.WriteLine("Цена 'Стоимость двас': " + value);
        }
        else
        {
            Console.WriteLine("Кнопка 'Двас' не найдена.");
        }

        if (table.Remove("Двас"))
        {
            Console.WriteLine("Убрана кнопка 'Двас'");
        }
        else
        {
            Console.WriteLine("Кнопка 'Двас' не найдена для уничтожения.");
        }

        Console.WriteLine("Счёт после уничтожения: " + table.Count);
    }
}
