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
