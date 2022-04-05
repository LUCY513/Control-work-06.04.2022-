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
