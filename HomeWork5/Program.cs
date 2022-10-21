// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


/*int[] RandomArray(int size,int min,int max) 
{
    int[] newArray = new int [size];
    for(int i = 0; i < size; i++)
        {
            Console.Write("Input array: ");
            newArray[i] = new Random().Next(min,max +1);
        }

    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int NumbersP (int[] array)

{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
        {
            if(array[i] % 2 == 0)
            sum ++;

        }
    return sum;

}

int[] arr = RandomArray(3,100,999);
Console.WriteLine($"Array : {arr}");
ShowArray(arr);
Console.WriteLine($"In Array{NumbersP(arr)}");

*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*int[] RandomArray(int size,int min,int max) 
{
    int[] newArray = new int [size];
    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(min,max);

    return newArray;
}

void ShowArray(int[]array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
Console.WriteLine();
}

int SumCurrent (int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i++)
    {
        sum += array[i];
    }

return sum;
}

int[] arr = RandomArray(1,10,50);
ShowArray(arr);
Console.WriteLine($"{SumCurrent} and {ShowArray}");

*/


//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] RanArray (int size, int min, int max)
{
    double[] array = new double[size];

    for (int i = 0;i < array.Length; i++)
    {
        double newArr = new Random().NextDouble();
        newArr = newArr * Math.Pow(10, new Random().Next(0, min +1));
        newArr = Math.Round(newArr,max);
        newArr = newArr * (Math.Pow(-1, new Random().Next(0,2)));
        array[i] = newArr;
    }
    return array;
}

void PrintArray (double[]array)
{
    Console.Write("{ ");
    for(int i = 0;i < array.Length;i++)
    {
        Console.Write(array[i]);
        if(i < array.Length -1)
            Console.Write(", ");
    }
    Console.WriteLine(" }");
}

int ShowArray (string msg)
{
    Console.Write(msg +">:");
    int number = Convert.ToInt32(Console.ReadLine());
    while(number < 0)
    {
        Console.WriteLine("!!!");
        Console.Write(msg + ">:");
        number = Convert.ToInt32(Console.ReadLine());
    }
   return number;
}

double DifMinMAx (double[] arr)
{
    double min = arr[0];
    double max = arr[0];

    for(int i = 1; i < arr.Length;i++)
    {
        if(arr[i]> max)max = arr[i];
        else if (arr[i] < min) min = arr[i];
    }
    return max - min;
}

int arrSize = ShowArray();
int max = ShowArray();
int min = ShowArray();

double[] array1 = RanArray(arrSize,min,max);
Console.WriteLine($"Array {arrSize} for digit ({-Math.Pow(10,max)},({Math.Pow(10,min)}");
PrintArray(array1);
Console.WriteLine($"{DifMinMax(array1)}");

