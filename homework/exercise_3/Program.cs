// Задача 59: Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив: 

int minVal = Int32.MaxValue;
int indexRows =0;
int indCol = 0;

Console.WriteLine("Введите кол-во строк");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кол-во колонок");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] array = new int [rows,columns];
int [,] GetArray()
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        
           array[i,j] = new Random().Next(0,10);
           if (minVal>array[i,j])
           {
            minVal = array[i,j];
            indexRows = i;
            indCol = j;
           }
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

void ChangeArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i!=indexRows)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j!=indCol){
                    Console.Write(array[i,j]);
                }
        
                
            }
            
        
        }
        Console.WriteLine();
    }

}

PrintArray(GetArray());
 Console.WriteLine("____________");
ChangeArray(array);