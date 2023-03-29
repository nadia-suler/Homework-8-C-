//Task 54: Specify a two-dimensional array. Write a program to sort in descending order the elements of each row of a two-dimensional array.

    /*
    int[,] FillMatrixWithRandom(int row, int column)
{
int[,] array = new int[row, column];
Random rnd = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
array[i, j] = rnd.Next(0, 10);
}
}
return array;
}

void PrintMatrix(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
Console.Write($"{array[i, j]} \t");
}
Console.WriteLine();
}
}



    void PrintNewMatrix(int[,] array)
    {
    for(int i = 0; i < array.GetLength(0); i++)
    {
      for(int j = 0; j < array.GetLength(1) - 1; j++)
      {
        for(int z = 0; z < array.GetLength(1) - 1; z++)
        {
          if(array[i,z] < array[i,z+1])
          {
            int newMatrix = 0;
            newMatrix = array[i,z];
            array[i,z] = array[i,z+1];
            array[i,z+1] = newMatrix;
          }
        }
      }
    }
     PrintMatrix(array); 
    }

Console.Write("Input a number of rows: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrixWithRandom(row, column);
PrintMatrix(matrix);
Console.WriteLine();
  Console.WriteLine("New matrix ");
  PrintNewMatrix(matrix);
    
*/

   /*
    //Task 56: Specify a rectangular two-dimensional array. Write a program to find the string with the smallest sum of elements.

    int[,] FillMatrixWithRandom(int row, int column)
{
int[,] array = new int[row, column];
Random rnd = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
array[i, j] = rnd.Next(0, 10);
}
}
return array;
}

void PrintMatrix(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
Console.Write($"{array[i, j]} \t");
}
Console.WriteLine();
}
}

    void MinRow(int[,] array)
    {
  int minsum = Int32.MaxValue;
  int indexRow = 0;
    
    for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[i, j];        
    }
    if (sum < minsum)
    {
        minsum = sum;
        indexRow++;
    }
}
  Console.WriteLine($"The row with the min sum of the elements is {indexRow}, the sum is {minsum}");
  }


Console.Write("Input a number of rows: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrixWithRandom(row, column);
PrintMatrix(matrix);
MinRow(matrix);
*/
    

    /*
    //Task 60. Form a three-dimensional array of non-repeating two-digit numbers. Write a program that will print an array line by line, adding the indexes of each element.

  int countNums = 90;
    int[,,] Create3DMatrix(int size1, int size2, int size3)
{  
    int[,,] array = new int[size1, size2, size3];
    int[] values = new int[countNums];
    int num = 10;
    for (int i = 0; i < values.Length; i++)
        values[i] = num++;

    for (int i = 0; i < values.Length; i++)
    {
        int randomInd = new Random().Next(0, values.Length);
        int temp = values[i];
        values[i] = values[randomInd];
        values[randomInd] = temp;
    }

    int valueIndex = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = values[valueIndex++];
            }
        }
    }
    return array;
}

void indexNum(int[,,] array)
    {
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            Console.WriteLine($"[{i},{j},{k}] - {array[i, j, k]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
  }

    
int dimension1 = InputInt("Input dimension 1: ");
int dimension2 = InputInt("Input dimension 2: ");
int dimension3 = InputInt("Input dimension 3: ");


if (dimension1 * dimension2 * dimension3 > countNums)
{
    Console.Write("Array is too big");
    return;
}

int[,,] resultNums = Create3DMatrix(dimension1, dimension2, dimension3);



indexNum(resultNums);


int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
*/
   
