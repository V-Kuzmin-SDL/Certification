
string[] initialArray = { "hello", "2", "world", ":-)" };

// Выводим первоначальный массив на экран
Console.WriteLine("Первоначальный массив строк:");
foreach (var str in initialArray)
{
Console.WriteLine(str);
}

// Подсчитываем, сколько строк удовлетворяют условию
int count = 0;
foreach (var str in initialArray)
{
if (str.Length <= 3)
{
count++;
}
}

// Создаем новый массив для строк, удовлетворяющих условию
string[] resultArray = new string[count];

// Заполняем новый массив подходящими строками
int index = 0;
foreach (var str in initialArray)
{
if (str.Length <= 3)
{
resultArray[index++] = str;
}
}

// Выводим результат на экран
Console.WriteLine("Новый массив строк, длина которых меньше или равна 3 символам:");
foreach (var str in resultArray)
{
Console.WriteLine(str);
}

