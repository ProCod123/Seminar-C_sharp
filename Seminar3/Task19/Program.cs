Console.WriteLine("Введите пятизначное положительное число");
int x = Convert.ToInt32(Console.ReadLine());


void CheckPalindrom(int x){
//Находим первое, второе, четвертое и пятое число.
int number1 = x / 10000;
int number2 = (x / 1000) % 10;
int number4 = x % 100/10;
int number5 = x % 10;

//Проверяем яв-ся ли число пятизначным и положительным
if (Convert.ToString(x).Length == 5 && x > 0){
    //Сравниваем первое число с последним, второе с предпоследним
    if (number1 == number5 && number2 == number4) Console.WriteLine($"Число {x} является палиндромом");
    else Console.WriteLine($"Число {x} не является палиндромом");
}
else Console.WriteLine($"Вы ввели не пятизначное положительное число!");
}

CheckPalindrom(x);
