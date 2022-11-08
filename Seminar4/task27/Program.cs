Console.WriteLine("Введите число");
string number = Console.ReadLine();
int sum = 0;

for (int i = 0; i < number.Length; i++){
    sum += Convert.ToInt32(number[i].ToString());
    }
Console.WriteLine($"Сумма цифр входящих в число равна: {sum}");

