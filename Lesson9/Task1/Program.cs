//Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
//M = 1; N = 5 -> "2, 4"
//M = 4; N = 8 -> "4, 6, 8"

//функция, запрашивающая значение начала или конца интервала у пользователя и возвращающая его в интовом значении

int GetIntervalValue(string Name)
{
    Console.Write($"Введите {Name} -> ");
    string ValueStr = Console.ReadLine();

    return Convert.ToInt32(ValueStr);
}

bool IsEven(int Number)
{
    return Number % 2 == 0;
}

string GetEvenNumbers(int Start, int End)
{
    if (IsEven(Start))
    {
        if (Start < End)
        {
            return Start + ", " + GetEvenNumbers(Start + 1, End);
        }
        else
        {
            return Start + "";
        }
    }
    else
    {
        if (Start < End)
        {
            return GetEvenNumbers(Start + 1, End);
        }
        return "";
    }

}

//начало программы

int StartInterval = GetIntervalValue("M");
int EndInterval = GetIntervalValue("N");
string EvenNumbers = GetEvenNumbers(StartInterval, EndInterval);
Console.WriteLine($"M = {StartInterval}; N = {EndInterval} -> {EvenNumbers}");