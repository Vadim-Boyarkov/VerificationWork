string[] arr(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = ReadS("Введите строку");
    }
    return array;
}
string ReadS(string message)
{
    Console.WriteLine(message);
    return Console.ReadLine();
}
int ReadI(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int SearchCount(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count = count + 1;
        }
    }
    return count;
}
string[] SearchString(string[] array, int size)
{
    string[] rezult = new string[size];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            rezult[j] = array[i];
            j++;
        }
    }
    return rezult;
}

int sizeArray = ReadI("Введите длинну массива");
string[] text = arr(sizeArray);
int count = SearchCount(text);
string[] rezult = SearchString(text, count);
Console.WriteLine($"Массив из строк, длина которых меньше либо равна {3}: [ {string.Join(", ", rezult)} ]");
