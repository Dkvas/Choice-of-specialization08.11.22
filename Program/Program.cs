using static System.Console;
Clear();

string[] CreateArray(int size)
{
    string[] newArray = new string[size];
    for (int i = 0; i < newArray.Length; i++)
    {
        WriteLine($"Введите {i + 1} элемент массива: ");
        newArray[i] = Convert.ToString(ReadLine());
    }
    return newArray;
}
void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Write(array[i] + ", ");
    WriteLine();
}
void ThreeSymbolsArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int len = 3;
        if (array[i].Length <= len)
            Write(array[i] + ", ");
    }
}

WriteLine("Введиете длинну массива: ");
int a = Convert.ToInt32(ReadLine());
string[] myArray = CreateArray(a);
ShowArray(myArray);

WriteLine("Массив из трёх или менее символов : ");
ThreeSymbolsArray(myArray);
WriteLine();
