//Задача 15 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите номер дня недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
string nameOfTheDay = " ";

switch (dayNumber)
{
  case 1:
    nameOfTheDay = "Monday";
    break;
  case 2:
    nameOfTheDay = "Tuesday";
    break;
  case 3:
    nameOfTheDay = "Wednesday";
    break;
  case 4:
    nameOfTheDay = "Thursday";
    break;
  case 5:
    nameOfTheDay = "Friday";
    break;
  case 6:
    nameOfTheDay = "Saturday";
    break;
  case 7:
    nameOfTheDay = "Sunday";
    break;
  default:
    Console.WriteLine("В неделе только семь дней");
    break;
}
    Console.WriteLine(nameOfTheDay);

    if (dayNumber == 6 || dayNumber == 7)
        Console.WriteLine("Это выходной! Гуляем!");
    else if (dayNumber < 6 && dayNumber > 0)
        Console.WriteLine("Сегодня будни... Кошмар...");
    else 
        Console.WriteLine("От работы не убежишь!");