/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. */

int [] numbers = new int[8];
Console.Write("[");

int array (int a)
{
    return numbers[a];
}

for (int i = 0; i < numbers.Length; i++)
 {
    numbers [i] = new Random().Next(0, 11);
    Console.Write(" " + array (i) + " ");
 }
Console.Write("]");

