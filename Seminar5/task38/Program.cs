//Создаем массив заполенный вещественными числами от 0,0 до 10,0
double[] array = new double[5];
for (int i = 0; i < array.Length; i++){
    array[i] = new Random().NextDouble()*10;
}
Console.Write("Сгенерированный массив:");
Console.WriteLine("[{0}]", string.Join(", ", array));

double SubtrMaxMin(double[] array){
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i ++){
        if (array[i] < min){
            min = array[i];
        }
        if (array[i] > max){
            max = array[i];
        }
    }
    Console.WriteLine($"{min}   {max}");
    double subtr = max - min;
    return subtr;
    }
double result = SubtrMaxMin(array);
Console.WriteLine($"Разница между максимальным и минимальным числом в массиве: {result}");