using System;

// 1. 
Random countElementsArray = new Random();
// 2.
int N = countElementsArray.Next(0, 4);
// 3. 
Console.WriteLine("<<Ввыводит три случайных символа из списка имеющихся элементов>>");
Console.ReadLine();
// 4.                         i =     0        1      2      3     4     5         6         7      8
string[] arrayChar = new string[] { "♥GB♥ ", ":з ", "o_o ", "☼ ", "Z ", ":) ", ":-:-:-: ", "♦♦♦ ", "TS " };
// 5.
string[] arrayGet = new string[N];

// 8.
PrintArray("<<Список символов>>", arrayChar);
GetArrayNElements(arrayChar, arrayGet);
PrintArray("<<Получили>>", arrayGet);

// 6.
void PrintArray(string text, string[] arr)
{
    Console.WriteLine(text);
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
    }
    Console.WriteLine();
}
// 7.
string[] GetArrayNElements(string[] array, string[] ar)
{
    Console.WriteLine();
    // 1.
    if (N > 0)
    {
        for (int i = 0; i < N; i++)                                 // 
        {
            Random GetPositionElements = new Random();              // I.
            int M = GetPositionElements.Next(0, arrayChar.Length);  // II.
            ar[i] = array[M];                                       // III.
        }
        return ar;                                                  // IV.
    }
    // 2.
    else Console.WriteLine("[ ]");                                  // I.
    return ar;                                                      // II.
}