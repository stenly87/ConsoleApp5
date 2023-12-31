﻿// Условные операторы в C#
// bool
// существуют операции сравнения:
// <  меньше
// <= меньше или равно
// >  больше
// >= больше или равно
// != не равно
// == равно
int a = 10, b = 11, c = 10;
bool result = a < b;// true
result = a > b;  // false
result = a >= b; // false
result = a >= c; // true
result = a != b; // true
result = a != c; // false
result = a == b; // false
result = a == c; // true
result = (c < a) & (a < b); // false (поскольку false & true)
Console.WriteLine(result);
result = !(c < a) && (a < b);// true (поскольку true & true)
Console.WriteLine(result);
// && &
// || |
result = !(c < a) || (a < b); 
// поскольку левая возвращает true и итог выражения = true
Console.WriteLine(result);
// разветвляющие операторы
// оператор "если"
/*
if (логическое выражение 1) // проверяется выражение
{                           // если выражение = true
    блок 1                  // вычисляется блок 1 и выход
}
else if (логическое выражение 2) // может присутствовать
{                                // в нескольких экземплярах
    блок 2                       // или отсутствовать
}
else if (логическое выражение 3)
{ // скобочки представляют собой тело после выражения
  // скобочки можно опустить, если тело состоит из 1 строки
    блок 3  // блоки кода включают почти любой код
}
else // выполняется, если не выполнено ни одно выражение выше
{    // может отсутствовать
    блок 4
}

*/
/*
if (a > b)
{
    Console.WriteLine("Выполнено первое условие");
    Console.WriteLine("a действительно меньше чем b");
}
else if (a != c)
{
    Console.WriteLine("Выполнено второе условие");
    Console.WriteLine("a действительно равно с");
}
else
    Console.WriteLine("эту строчку никто не увидит?");
*/

// тернарный оператор
// сокращенный вариант оператора if
int s = a > c ? 20 : 25;
// синтаксис: условие ? (знач. если true) : (знач. если false)
// ниже то же самое с оператором if
if (a > c)
    s = 20;
else
    s = 25;

// switch
// классический вариант (остальные позже)
/*
switch (значение) // значение может быть переменной/выражением//методом
{// значение вычисляется, это может быть любой тип данных
    case значение1: // если значение совпадает с вычисленным
        блок 1      // выполняется блок 1 и происходит выход
    break;
    case значение2:
        блок 2
    break;
    case значение3:
        блок 3
    break;
    default: // может отсутствовать, выполняется если не нашлось
        блок 4 // ни одного case, совпадающего со значением
    break;
}    
*/

switch (a + c)
{
    case 10:
        Console.WriteLine("Как так?");
        break;
    case 20:// выполнится данный блок
        Console.WriteLine("a + c = 20!");
        break;
    default:
        Console.WriteLine("Работа switch по умолчанию");
        break;
}

switch (a + b + c)
{
    case 10:
    case 20:
 // так нельзя! Console.WriteLine("Выполнился какой-то из case");
    case 30:
    case 31: // выполнится. Если убрать эту строку, не выполнится
        Console.WriteLine("Выполнился какой-то из case");
        break;
}