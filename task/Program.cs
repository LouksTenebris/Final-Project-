Console.Write("Сколько элементов? ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Больше скольки элементов должно быть? ");
int len = Convert.ToInt32(Console.ReadLine());

string[] arrayStrings = new string[size];
for (int i = 0; i < size; i++)
{
 Console.WriteLine($"Введите {i+1}-й элемент: ");
 string element = Convert.ToString(Console.ReadLine());
 arrayStrings[i] = element;
}

string[] arrayFinal = new string[size];
int pos = 0;

for (int j = 0; j < size; j++)
{
 if (arrayStrings[j].Length <= len)
    {
 arrayFinal[pos] = arrayStrings[j];
 pos++;
    }
}

Console.WriteLine();
Console.Write($"Из введёных элементов больше или равно {len} = ");
PrintArray(arrayFinal);

void PrintArray(string[] array)
{
 for (int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
 Console.WriteLine();
}