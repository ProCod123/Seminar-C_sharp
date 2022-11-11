//Создаем массив заполенный трехзначными числами
int[] array = new int[10];
for (int i = 0; i < array.Length; i++){
    array[i] = new Random().Next(100,999);
}
Console.Write("Сгенерированный массив:");
Console.WriteLine("[{0}]", string.Join(", ", array));

int CountEven(int[] array){
    int count = 0;
    for (int i = 0; i < array.Length; i++){
        if (array[i] % 2 == 0){
            count += 1;
        }
    }
    return count;
    }

int result = CountEven(array);
Console.WriteLine($"Количество четных числе в массиве: {result}");
