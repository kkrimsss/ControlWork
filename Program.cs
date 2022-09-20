string[] arrayFirst = new string[5] { "hello", "2", "world", ":)", "dmitriy" };
string[] arraySecond = new string[arrayFirst.Length];
int count = 0;
for (int i = 0; i < arrayFirst.Length; i++)
{
    if (arrayFirst[i].Length <= 3)
    {
        arraySecond[count] = arrayFirst[i];
        Console.Write($"{arraySecond[count]} ");
        count++;
    }
}
