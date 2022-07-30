Console.Clear();

Console.Write("Введите длину массива строк, не более 10: ");

int size;

if (int.TryParse(Console.ReadLine(), out size) && size > 0 && size <= 10)
{
    Console.WriteLine("Заполните массив строками!");
}
else
{
    Console.WriteLine("Введены не допустимые символы!");
    return;
}

string[] strArray = new string[size];

FillArray(strArray);
PrintArray(strArray);

Console.WriteLine();

void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i} элемент массива: ");
        array[i] = Console.ReadLine();
    }
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"\"{array[i]}\", ");
        }
        else Console.Write($"\"{array[i]}\"");
    }
    Console.Write("]");
}