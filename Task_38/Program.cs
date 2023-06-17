// Задача 38: Задайте массив вещественных случайных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.



void FillArray(double[] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rand.Next(0, 10001) * 0.01, 2);

    }
}

void PrintArray(double[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item} ");
    }
    System.Console.WriteLine();
}

void FindMinMax(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];

        else if (array[i] > max)

            max = array[i];

        else if (array[i]! < min | array[i]! > max)

            break;
    }
    System.Console.WriteLine($"мин {min}");

    System.Console.WriteLine($"макс {max}");
    System.Console.WriteLine();

    System.Console.WriteLine($"разница между максимальным и минимальным значением равна {max - min}");

}

Console.Clear();
System.Console.WriteLine("Введите размерность массива ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
FillArray(array);
PrintArray(array);
FindMinMax(array);
