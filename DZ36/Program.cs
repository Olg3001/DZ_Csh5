// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Programm to find the sum of the array elements with uneven positions");
Console.Write("Input the array elements number:\t");
int input = int.Parse(Console.ReadLine()!);

if (input <= 0)
{
    Console.WriteLine("Wrong input");
}

else
{
    int[] array = GetArray(input);

    int[] GetArray(int input)
    {
        int[] array = new int[input];
        Random random = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(-1000, 1000);
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

    int SumOfNumbersOnUnevenPositions(int[] array)
    {
        int sum = 0;

        for (int i = 1; i < array.Length; i += 2)
        {
            sum += array[i];
        }

        return sum;
    }

    PrintArray(array);

    int result = SumOfNumbersOnUnevenPositions(array);
    Console.WriteLine("\nThe sum of numbers on uneven positions is\t" + result);
}