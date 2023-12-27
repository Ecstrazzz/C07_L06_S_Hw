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

// Console.WriteLine("Введите строку содержащую латинские буквы в обоих регистрах:");
// string rowIn2Reg = Console.ReadLine();

// bool whatLang(string str)
// {
//     int engBig = 0;
//     int engSmall = 0;
//     int rusCount = 0;
//     string text = str;
//     bool eng = false;
//     foreach (char c in text)
//     {
//         if ((c >= 'а' && c <= 'я') || (c >= 'А' && c <= 'Я'))
//             rusCount++;
//         else if (c >= 'A' && c <= 'Z')
//             engBig++;
//         else if (c >= 'a' && c <= 'z')
//             engSmall++;
//     }
//     if (rusCount > 0 || engBig == 0 || engSmall == 0)
//     {
//         eng = false;
//     }
//     else if (engSmall > 0 && engBig > 0)
//     {
//         eng = true;
//     }
//     return eng;
// }

// if (rowIn2Reg.Length == 0)
// {
//     Console.WriteLine("Вы не ввели символы!");
// }
// else if (whatLang(rowIn2Reg) == false)
// {
//     Console.WriteLine("Вы не ввели строку согласно условию!");
// }
// else
// {
//     Console.WriteLine($"Результат:\n{rowIn2Reg.ToLower()}");
// }

// --------------------------------------------

// Задача 3: Задайте произвольную строку. Выясните,
// является ли она палиндромом.

// Пример: “aBcD1ef!-” => Нет
//         “шалаш” => Да
//         “55655” => Да

// Решение:

// Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");
// Console.WriteLine("Введите произвольную строку:");
// string arbitStr = Console.ReadLine();

// bool Palindrome(string str)
// {
//     string toStripeLow = new string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
//     return toStripeLow.SequenceEqual(toStripeLow.Reverse());
// }

// bool isPalindrome = Palindrome(arbitStr);
// Console.WriteLine(isPalindrome ? "Палиндром" : "Не палиндром");

// --------------------------------------------

// Задача 4*(не обязательная): Задайте строку, состоящую
// из слов, разделенных пробелами. Сформировать строку,
// в которой слова расположены в обратном порядке.
// В полученной строке слова должны быть также
// разделены пробелами.

// Пример: “Hello my world” => “world my Hello”

// Решение:

using System.Text.RegularExpressions;

Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");
Console.WriteLine("Введите слова с пробелами:");
string strWordsSeparateSpaces = Console.ReadLine();

string ReverseWords(string str)
{
    string[] words = str.Split(' ');
    Array.Reverse(words);
    return string.Join(" ", words);
}

bool noSymb(string str)
{
    string text = str;
    bool noSym = true;
    Regex reg = new Regex("(?![а-яА-Яa-zA-Z ]).");
    if (reg.IsMatch(text))
    {
        noSym = false;
    }
    else
    {
        noSym = true;
    }
    return noSym;
}

if (string.IsNullOrEmpty(strWordsSeparateSpaces) == true)
{
    Console.WriteLine("Вы не ввели слова!");
}
else if (noSymb(strWordsSeparateSpaces) == false)
{
    Console.WriteLine("Вы ввели недопустимые символы!");
}
else
{
    string res = ReverseWords(strWordsSeparateSpaces);
    Console.WriteLine($"Результат:\n{res}");
}