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

void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i} элемент массива: ");
        array[i] = Console.ReadLine();
    }
}