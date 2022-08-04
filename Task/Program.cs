string[] CreateArray(int lenght)
{
    string[] Array = new string[lenght];
    for (int i = 0; i < lenght; i++)
    {
        Array[i] = Convert.ToString(Console.ReadLine());
    }
    return Array;
}
string[] ArrayStringsLenghtLessThanThree(string[] array)
{
    string[] NewArray = new string[array.Length];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            NewArray[j] = array[i];
            j++;
        }
    }
    Array.Resize(ref NewArray, j);
    return NewArray;
}
void PrintArray(string[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < Array.Length - 1) Console.Write(Array[i] + ",");
        else Console.Write(Array[i] + "]");
    }
}
Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите {size} значений для массива через клавишу ENTER: ");
string[] array = CreateArray(size);
string[] ResultArray = ArrayStringsLenghtLessThanThree(array);
PrintArray(ResultArray);