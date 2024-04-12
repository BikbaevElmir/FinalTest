string[] AddArray()
{
    Console.WriteLine("Введите символы строк массива разделяя пробелами");
    string str = Console.ReadLine();
    string[] narray = str.Split(" ");
    return narray;
}

string[] NewArray(string[] array)
{
    string str = "";
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            str = str + " " + array[i];
        }
    }
    return str.Split(" ");
}

// start
string[] arr1 = AddArray();
Console.WriteLine("Исходный массив :");
foreach (string st in arr1)
{
    Console.Write($"{st}\t");
}
Console.WriteLine("");
string[] arr2 = NewArray(arr1);
Console.WriteLine("Новый массив :");
foreach (string st in arr2)
{
    Console.Write($"{st}\t");
}