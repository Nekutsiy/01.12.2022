// /Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Введите кол-во строк");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кол-во колонок");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];
int[,] GetArray()
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            array[i, j] = new Random().Next(0, 11);
        }
    }
    return array;
}
int[,] PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            Console.Write(array[i, j]);
        }
        Console.WriteLine();
    }
    return array;
}

void ChangeArray(int[,] array)
{
    int rowsCount = array.GetLength(0) - 1;

    for (int i = 0; i < array.GetLength(1); i++)
    {
        int temp = array[0, i];
        array[0, i] = array[rowsCount, i];
        array[rowsCount, i] = temp;

    }


}

PrintArray(GetArray());
Console.WriteLine("____________");
ChangeRows(array);
PrintArray(array);