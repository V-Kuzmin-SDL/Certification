
// программа, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 

string[] initialArray = { "Sunny", "17", "Sol", ":-)" };
Console.WriteLine("Первоначальный массив строк:");
foreach (var str in initialArray)
{
    Console.WriteLine(str);
}

int count = 0;
foreach (var str in initialArray)
{
    if (str.Length <= 3)
    {
        count++;
    }
}

string[] resultArray = new string[count];
int index = 0;
foreach (var str in initialArray)
{
    if (str.Length <= 3)
    {
        resultArray[index++] = str;
    }
}
Console.WriteLine("Новый массив строк, длина которых меньше или равна 3 символам:");
foreach (var str in resultArray)
{
    Console.WriteLine(str);
}


