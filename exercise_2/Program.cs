// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

Console.WriteLine("Введите кол-во строк");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кол-во колонок");
int columns = Convert.ToInt32(Console.ReadLine());

if (rows!=columns)
    {
         Console.WriteLine("В этой матрице мы не можем заменить элементы");
         return;
    }

int [,] array = new int [rows,columns];
int [,] GetArray()
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        
           array[i,j] = new Random().Next(0,11);
        }
    }
    return array;
}
void PrintArray(int[,]array)
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        
           Console.Write(array[i,j]);
        }
        Console.WriteLine();
    }
    
    
}
int [,] ChangeArray(int [,] array)
{
    

    int [,] array2 = new int[array.GetLength(0),array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array2[j,i] =array[i,j];
        }
    }
    return array2;
    

}

PrintArray(GetArray());
 Console.WriteLine("____________");
PrintArray(ChangeArray(array));