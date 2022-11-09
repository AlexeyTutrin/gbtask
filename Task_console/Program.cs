using static System.Console;



string[] StringsArray = new string[] { "hello", "2", "world", "br" };
string[] NewArray = new string[StringsArray.Length];

void NewArrayWithWords(string[] FirstArray, string[] SecondArray)
{
    int result = 0;
    for (int i = 0; i < FirstArray.Length; i++)
    {
        if (FirstArray[i].Length <= 3)
        {
            SecondArray[result] = FirstArray[i];
            result++;
        }
    }
}

void PrintArray(string[] Array)
{
    Write("[");
    for (int i = 0; i < Array.Length; i++)
    {
        Write($"{Array[i]}, ");
    }
    Write("]");
}

NewArrayWithWords(StringsArray, NewArray);
PrintArray(NewArray);