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

int sizeArrayNew = 0;

for (int i = 0; i < strArray.Length; i++)
{

    if (strArray[i].Length <= 3)
    {
        sizeArrayNew++;
    }
}

string[] strArrayNew = new string[sizeArrayNew];
int j = 0;

for (int i = 0; i < strArray.Length; i++)
{
    if (strArray[i].Length <= 3)
    {
        strArrayNew[j] = strArray[i];
        j++;
    }
}

Console.WriteLine("Новый массив строк:");
PrintArray(strArrayNew);

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