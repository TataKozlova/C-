﻿
//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
//создать массив недели
string[] Days = {"понедельник","вторник", "среда", "четверг", "пятница", "суббота", "воскресенье"};
//запросить у пользователя цифру от 1 до 7
System.Console.WriteLine("Введите число от 1 до 7");
string Number = Console.ReadLine();
int Index = Convert.ToInt32(Number) - 1;
//если индекс элемента массива < 5, выводим, что это выходной "да, выходной"
//иначе выводим "нет, рабочий"
if (Index > 6){
 System.Console.WriteLine("в неделе только 7 дней, балбес!");   
} else {
  if (Index < 5){
System.Console.WriteLine($"нет, это - {Days[Index]} (рабочий)");
} else {
    System.Console.WriteLine($"да, это - {Days[Index]} (выходной)");
}  
}
