# Итоговая контрольная по основному блоку
## Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Блок-схема решения задачи приложена в [файле](../Shema.pdf).

Решение задачи реализовано в C#.

### Написание кода происходило в несколько этапов

1. Создана функция для создания нового массива строк AddArray(). Ввод значений нового массива осуществляется с консоли разделяя символы пробелами. Введенная строка при помощи метода Split() с разделение по символу " " возвращается функцией в виде одномерного массива.
2. Создана функция для обработки данного массива  и создания нового массива по результату обработки NewArray(string[] array). Данная функция циклом переберает принятый массив и элементы в которых символов меньше или равно 3 добоваляет к переменной str  с  пробелом (str = str + " " + array[i];).
Далее методом Split() с разделение по символу " " преобразованная строка str возвращается функцией в виде одномерного массива.
3. Написание кода для запуска фунции ввода нового массив и вывода его в консоле : string[] arr1 = AddArray();
Console.WriteLine("Исходный массив :");
foreach (string st in arr1)
{
    Console.Write($"{st}\t");
}

4. Написание кода для запуска функции обработка введенного массива и вывода результата в консоль: Console.WriteLine("");
string[] arr2 = NewArray(arr1);
Console.WriteLine("Новый массив :");
foreach (string st in arr2)
{
    Console.Write($"{st}\t");
}