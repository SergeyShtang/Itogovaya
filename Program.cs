// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам.

string[] myArray = { ";)", "Saratov", "GeekBrains", "GB", "99" };
string str = string.Join(", ", myArray);
Console.Write($"[{str}] -> ");

for (int i = 0; i < myArray.Length; i++)


{
    if (myArray[i].Length <= 3)
    {
        if (i != myArray.Length - 1)
        {
            Console.Write($"{myArray[i]}, ");
        }
        else
        {
            Console.Write($"{myArray[i]}");
        }
    }
}