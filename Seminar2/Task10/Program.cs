Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int first = number / 100;
int last = number % 10;
int middle_number = (number - first * 100 - last)/10;
Console.Write(middle_number);
