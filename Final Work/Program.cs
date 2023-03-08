//функция, которая возвращает строку из полученного массива

string ArrayToString(string[] Words)
{
    string Result = "[";
    string Separator = ", ";

    for (int i = 0; i < Words.Length; i++)
    {
        if (i == Words.Length - 1)
        {
            Separator = "]";
        }
        Result = Result + Words[i] + Separator;
    }
    return Result;
}

string[] words = {"кот", "ток", "торт"};

string test = ArrayToString(words);

Console.WriteLine(test);
