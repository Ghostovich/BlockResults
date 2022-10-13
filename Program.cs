string[] GetArray1 (string a, string b, string c, string d)
{
    string[] array1 = new string[4] {a, b, c, d};
    return array1;
}

string[] GetArray2 (string[] array1)
{   
    int j = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length<=3)
        {
            j++;
        }
    }

    string[] array2 = new string[j];

    int k = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length<=3)
        {
            array2[k] = array1[i];
            k++;
        }
    }  
    return array2;
}

Console.WriteLine("Введите элементы массива:");
string a = Console.ReadLine();
string b = Console.ReadLine();
string c = Console.ReadLine();
string d = Console.ReadLine();
Console.WriteLine();

string[] print1 = GetArray1(a, b, c, d);
Console.Write("[");
Console.Write(string.Join(", ", print1));
Console.Write("] -> [");
string[] print2= GetArray2(print1);
Console.Write(string.Join(", ", print2));
Console.Write("]");