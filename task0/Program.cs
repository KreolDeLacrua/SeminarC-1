//  Напишите программу, которая на вход
//  принимает число и выдает его 
//  квадрат (число умноженное на само себя)

Console.WriteLine("Введите число: ");  //приглашение к вводу
int number = Convert.ToInt32(Console.ReadLine()); //запрос данных в консоль, преобразование в число и запись в переменную

// Int16 == short
// Int32 == int
// Int64 == long

Console.WriteLine(number * number);
