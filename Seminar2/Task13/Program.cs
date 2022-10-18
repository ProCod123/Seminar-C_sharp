Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int result = number;
int n = 0;
// Считаем количество знаков в числе
while (result > 0){
    result = result / 10;
    n++;
    }
//Если знаков больше двух, то находим третье число    
if (n > 2){
    int third_number = number / Convert.ToInt32(Math.Pow(10, n - 3)) % 10;
    Console.WriteLine($"Третья цифра в числе: {third_number}");
}
else{
    Console.WriteLine($"Число слишком маленькое!");
}





