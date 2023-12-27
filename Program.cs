// Знакомство с языками программирования (семинары)

// Урок 6. Массивы и строки

// Задача 1: Задайте двумерный массив символов
// (тип char [,]). Создать строку из символов этого массива.

// Пример: a b c => “abcdef”
//         d e f

// Решение:

// char[,] symbols = new char[2, 3]
// {
//     {'a', 'b', 'c'},
//     {'d', 'e', 'f'}
// };

// string GetStringFromArray()
// {
//     string str = "";
//     for (int i = 0; i < symbols.GetLength(0); i++)
//     {
//         for (int j = 0; j < symbols.GetLength(1); j++)
//         {
//             str += symbols[i, j];
//         }
//     }
//     return str;
// }

// Console.WriteLine(GetStringFromArray());

// --------------------------------------------

// Задача 2: Задайте строку, содержащую латинские
// буквы в обоих регистрах. Сформируйте строку,
// в которой все заглавные буквы заменены на строчные.

// Пример: “aBcD1ef!-” => “abcd1ef!-”

// Решение:

// Если максимально просто
// string rowIn2Reg = "aBcD1ef!-";
// Console.WriteLine(rowIn2Reg.ToLower());

// Если приукрасить и разнообразить

Console.WriteLine("Введите строку содержащую латинские буквы в обоих регистрах:");
string rowIn2Reg = Console.ReadLine();

bool whatLang(string str)
{
    int engBig = 0;
    int engSmall = 0;
    int rusCount = 0;
    string text = str;
    bool eng = false;
    foreach (char c in text)
    {
        if ((c > 'а' && c < 'я') || (c > 'А' && c < 'Я'))
            rusCount++;
        else if (c >= 'A' && c <= 'Z')
            engBig++;
        else if (c >= 'a' && c <= 'z')
            engSmall++;
    }
    if (rusCount > 0 || engBig == 0 || engSmall == 0)
    {
        eng = false;
    }
    else if (engSmall > 0 && engBig > 0)
    {
        eng = true;
    }
    return eng;
}

if (rowIn2Reg.Length == 0)
{
    Console.WriteLine("Вы не ввели символы!");
}
else if (whatLang(rowIn2Reg) == false)
{
    Console.WriteLine("Вы не ввели строку согласно условию!");
}
else
{
    Console.WriteLine($"Результат:\n{rowIn2Reg.ToLower()}");
}