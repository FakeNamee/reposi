/* Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длинна которых меньше либо равно 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. */


static string[] GetStringsArray()
{
    string[] stringsArray = new string[4];
    int finalArrayLength = 0;
    int finalArrayIndex = 0;

    for (int i = 0; i < stringsArray.Length; i++)
    {
        Console.WriteLine("Введите строку: ");
        stringsArray[i] = Console.ReadLine();

        if (stringsArray[i].Length <= 3)
        {
            finalArrayLength++;
        }
    }

    string[] finalStringArray = new string[finalArrayLength];

    foreach (string str in stringsArray)
    {
        if (str.Length <= 3)
        {
            finalStringArray[finalArrayIndex++] = str;
        }
    }

    return finalStringArray;

}
string[] Array = GetStringsArray();
foreach (string str in Array)
{
    Console.Write(str);
}