// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Program to count the number of even numbers in the random array");

Console.Write("Input the array elements number:\t");

int input = int.Parse(Console.ReadLine()!);

if (input <= 0)
{
    Console.WriteLine("Wrong input");
}
else {
int[] GetArray(int input)
{
    int[] array = new int[input];
    Random random = new Random();
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 1000);
    }

    return array;
}

void PrintArray(int[] array)
{
    Console.Write("New array\t {");

    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) 
            Console.Write(array[i] + ", ");
        else 
            Console.Write(array[i]);
    }

    Console.Write("}");
}

int CountEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

int[] array = GetArray(input);
int result = CountEvenNumbers(array);

PrintArray(array);

Console.WriteLine("\nThe even numbers quantity in array is\t" + result);
}