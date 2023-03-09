//функция, которая возвращает строку из полученного массива

string GetSeparator(bool IsLastElement, bool IsEmptyElement)
{
    Console.WriteLine($"IsLastElement = {IsLastElement}");
    Console.WriteLine($"IsEmptyElement = {IsEmptyElement}");

    if (IsEmptyElement || IsLastElement)
    {
        return "";
    }
    return ", ";
}


string ArrayToString(string[] Words)
{

    string Result = "[";

    for (int i = 0; i < Words.Length; i++)
    {
        bool IsLast = i == Words.Length - 1;
        bool IsNextEmpty = !IsLast && Words[i + 1] == null;

        Console.WriteLine($"Words[{i}] = {Words[i]}");

        Result = Result + Words[i] + GetSeparator(IsLast, IsNextEmpty);
    }
    return Result + "]";
}

string GetWordsFromUser()
{
    Console.Write($"Введите слова через запятую: ");
    return Console.ReadLine();
}

string[] GetWordsArray(string Words)
{
    string[] WordsArray = Words.Split(new char[] { ',' });

    for (int i = 0; i < WordsArray.Length; i++)
    {
        WordsArray[i] = WordsArray[i].Trim();
    }

    return WordsArray;

}

string[] GetFiltredArray(int MaxLenght, string[] OriginalArray)
{
    string[] WordsArray = new string[OriginalArray.Length];
    int j = 0;

    for (int i = 0; i < OriginalArray.Length; i++)
    {
        if (OriginalArray[i].Length <= MaxLenght)
        {

            WordsArray[j] = OriginalArray[i];
            j++;
        };
    }

    return WordsArray;

}
//начало программы
string WordsFromUser = GetWordsFromUser();

Console.WriteLine($"данные от USER = {WordsFromUser}");

string[] words = GetWordsArray(WordsFromUser);

string[] FiltredWords = GetFiltredArray(3, words);

string FiltredArrayString = ArrayToString(FiltredWords);

Console.WriteLine(FiltredArrayString);
