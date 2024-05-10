string[] initialArray = { "Russia", "China", "Sol", ":-)" };
        Console.WriteLine("Первоначальный массив:");
        PrintArray(initialArray);

        string[] resultArray = FilterArray(initialArray);
        Console.WriteLine("Новый массив, длина строк меньше или равна 3 символам:");
        PrintArray(resultArray);
    

    static string[] FilterArray(string[] array)
    {
        int count = GetCountOfShortStrings(array);
        string[] resultArray = new string[count];

        int index = 0;
        foreach (var str in array)
        {
            if (str.Length <= 3)
            {
                resultArray[index++] = str;
            }
        }

        return resultArray;
    }

    static int GetCountOfShortStrings(string[] array)
    {
        int count = 0;
        foreach (var str in array)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }
        return count;
    }

    static void PrintArray(string[] array)
    {
        foreach (var str in array)
        {
            Console.WriteLine(str);
        }
    }



