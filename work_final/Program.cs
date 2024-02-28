﻿﻿string[] SelectRows(string[] firstArray, int knowLength)
{
    int i = 0;
    int k = 0;
    while (i<firstArray.Length)
    {
        if (firstArray[i].Length<=knowLength)
            k++;
        i++;
    }
    string[] secondArray = new string[k];
    i = 0;
    int n = 0;
    while (i<firstArray.Length)
    {
        if (firstArray[i].Length<=knowLength)
        {
            secondArray[n] = firstArray[i];
            n++;
        }
        i++;
    }
    return secondArray;
}
void PrintStringArray(string[] array)
{
    int l = 0;
    System.Console.Write("[");
    for (l=0; l<array.Length; l++)
    {
        System.Console.Write($"\"{array[l]}\"");
        if (l!=array.Length-1)
            System.Console.Write(", ");
    }
    System.Console.WriteLine("]");
}

// Для тестирования программы дан массив. 


string[] stringArray = new string[] { "1",":-)", "12345", "Кошка"};

string[] newStringArray = SelectRows(stringArray, 3);
System.Console.WriteLine("Массив строк на входе:");
PrintStringArray(stringArray);
System.Console.WriteLine("Массив строк на выходе:");
PrintStringArray(newStringArray);
