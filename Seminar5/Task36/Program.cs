//Создаем массив заполенный числами
int[] array = new int[5];
for (int i = 0; i < array.Length; i++){
    array[i] = new Random().Next(0,50);
}
Console.Write("Сгенерированный массив:");
Console.WriteLine("[{0}]", string.Join(", ", array));

int CountEvenPosition(int[] array){
    int sum = 0;
    for (int i = 0; i < array.Length; i = i + 2){
        sum += array[i];
        }
    return sum;
    }

int result = CountEvenPosition(array);
Console.WriteLine($"Сумма чисел с четными индексами в массиве: {result}");