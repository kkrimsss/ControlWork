string[] array1 = new string[5] { "hello", "2", "world", ":)", "dmitriy" };
string[] array2 = new string[array1.Length];
int count = 0;
for (int i = 0; i < array1.Length; i++)
{
    if (array1[i].Length <= 3)
    {
        array2[count] = array1[i];
        Console.Write($"{array2[count]} ");
        count++;
    }
}
