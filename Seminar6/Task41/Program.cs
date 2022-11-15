Console.WriteLine("Сколько чисел необходимо ввести?");
int number = Convert.ToInt32(Console.ReadLine());
int[] arrayPositive = new int[number];

int i = 0;
int count = 0;
while(i < number){
    Console.WriteLine($"Введите число № {i + 1}");
    int x = Convert.ToInt32(Console.ReadLine());
    if (x > 0) count ++; 
    i ++;
}

Console.WriteLine($"Было введено {number} чисел, из них {count} положительных");
