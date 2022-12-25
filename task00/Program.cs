string[] CreatrArrayString()
{
    Console.Write("Введите число для определения размера массива  ");
    int arg = Convert.ToInt32(Console.ReadLine());

    string[] arr = new string[arg];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("Введите строку  ");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

string[] array = CreatrArrayString();