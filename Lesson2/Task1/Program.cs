//получить у пользователя трехзначное число
System.Console.WriteLine("Введите трехзначное число");
string Number = Console.ReadLine();
//преобразовать строку в массив символов
char[] Numbers = Number.ToCharArray();
//вывести элемент массива с индексом 1

System.Console.WriteLine($"второе число - {Numbers[1]}");