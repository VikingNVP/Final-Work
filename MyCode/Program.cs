// Итоговая Задача.

Console.Clear();
string[] arrayA = new string[5] {"Welcome", "54", "apple", "words", "new"};
string[] arrayB = new string[arrayA.Length];
FillingSecondArray(arrayA, arrayB);
Console.Write("Array ");
PrintArray(arrayB);

void FillingSecondArray(string[] arrayA, string[] arrayB)
{
    int count = 0;
    for (int i = 0; i < arrayA.Length; i++)
    {
    if(arrayA[i].Length <= 3)
        {
        arrayB[count] = arrayA[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

