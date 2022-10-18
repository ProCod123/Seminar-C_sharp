Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int result = number;
int n = 0;

if (number > 99){
    while (result > 0){
        result = result / 10;
        n++;
    }
    int third_number = number / Convert.ToInt32(Math.Pow(10, n - 3)) % 10;
    Console.WriteLine($"Третья цифра в числе: {third_number}");
}
else{
    Console.WriteLine($"Число слишком маленькое!");
}





