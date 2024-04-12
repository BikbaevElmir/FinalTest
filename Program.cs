string[] AddArray()
{
    Console.WriteLine("Введите символы строк массива разделяя пробелами");
    string str = Console.ReadLine();
    string[] narray = str.Split(" ");
    return narray;
}