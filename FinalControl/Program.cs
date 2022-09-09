Console.Clear();

string[] array = { "A", "bB", "cCc", "dddd", "12_qaz", "3-4", "H_R" };

void comparisonArray(string[] array)
{
    string[] newArray = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[i] = array[i]; ;
            Console.Write($"{newArray[i]}, ");
        }
    }
    Console.WriteLine();
}

void Print(string[] Array)
{
    for (int i = 0; i < Array.Length; i++)
        Console.WriteLine();

}

Print(array);
comparisonArray(array);
Console.WriteLine();