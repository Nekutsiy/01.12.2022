// адача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет 
// местами первую и последнюю строку массива

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

void ChangeRows(int[,] array)
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