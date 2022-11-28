Console.Clear();

void FillArray(string[] array) //метод для заполнения массива
{
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите {i+1} элемент массива: ");
    array[i] = Console.ReadLine();
}
}

void PrintArray(string[] array) //метод для вывода массива в консоль
{
for (int i = 0; i < array.Length; i++)
{
    if (i < array.Length - 1) Console.Write(array[i] + ", ");
    else Console.Write(array[i]);
}
Console.WriteLine();
}

Console.Write("Введите количество элементов n: "); //задали размер массива
int n = Convert.ToInt32(Console.ReadLine());
string[] strings = new string[n];

FillArray(strings); // заполнили массив строками

Console.WriteLine();
Console.WriteLine("Исходный массив: ");
PrintArray(strings); // вывели в консоль исходный массив

int count = 0;
for (int i = 0; i < strings.Length; i++) //нашли количество элементов в массиве, удовлетворяющих условиям задачи
{
    if (strings[i].Length < 4)
    {
        count++;
    } 
} 

string[] newstrings = new string[count]; // создали новый массив

int j = 0;
for (int i = 0; i < strings.Length; i++) // заполнили новый массив элементами
{
    if (strings[i].Length < 4)
    {
        newstrings[j] = strings[i];
        j++;
    } 
} 

Console.WriteLine();
Console.WriteLine("Итоговый массив: ");
PrintArray(newstrings); // вывели в консоль новый массив


