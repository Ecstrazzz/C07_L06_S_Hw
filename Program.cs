// Знакомство с языками программирования (семинары)

// Урок 6. Массивы и строки

// Задача 1: Задайте двумерный массив символов
// (тип char [,]). Создать строку из символов этого массива.

// Пример: a b c => “abcdef”
//         d e f

// Решение:

char[,] symbols = new char[2, 3]
{
    {'a', 'b', 'c'},
    {'d', 'e', 'f'}
};

string GetStringFromArray()
{
    string str = "";
    for (int i = 0; i < symbols.GetLength(0); i++)
    {
        for (int j = 0; j < symbols.GetLength(1); j++)
        {
            str += symbols[i, j];
        }
    }
    return str;
}

Console.WriteLine(GetStringFromArray());