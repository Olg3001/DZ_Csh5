// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.

Console.WriteLine("Programm to count the difference between max and min array elements");

Console.Write("Input the array elements number:\t");
int input = int.Parse(Console.ReadLine()!);

if (input <= 2)
{
    Console.WriteLine("Wrong input. Only two and more elemets could be compared.");
}

else
{
float[] array = GetArray(input);

float[] GetArray(int input)
{
    float[] array = new float[input];

    Console.WriteLine("Input the array elements. After every new element please press Enter");
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = float.Parse(Console.ReadLine()!);
    }
    
    return array;
}

void PrintArray(float[] array)
{
    Console.Write("New array {");

    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) 
            Console.Write(array[i] + ", ");
        else
            Console.Write(array[i]);
    }

    Console.Write("}");
}

float GetMin(float[] array)
{
    float min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
    }

    return min;
}

float GetMax(float[] array)
{
    float max = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
    }

    return max;
}

PrintArray(array);
GetMin(array);
GetMax(array);

float min = GetMin(array);
float max = GetMax(array);
float result = max - min;

Console.WriteLine("\nThe difference between max and min array elements is\t" + Math.Round(result, 3));
}