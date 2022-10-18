
Console.WriteLine("Введите номер дня недели");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0 & number < 8){
    if (number == 6 || number == 7){
        Console.Write($"{number}-й день недели ЯВЛЯЕТСЯ ВЫХОДНЫМ");
    }
    if (number > 0 & number < 6){
        Console.Write($"{number}-й день недели НЕ является выходным");
    }
    }
else {
    Console.Write($"В неделе всего 7 дней!!!");
}

