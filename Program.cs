/*
//ex one
double [,] Create2DRandomArray() //creating random double array with two decimal places
{
    Console.WriteLine("Input the number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input the number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input the min possible value: ");
    double min = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Input the max possible value: ");
    double max = Convert.ToDouble(Console.ReadLine());

    double[,] array = new double[rows, columns];
    for(int i = 0; i < rows; i++)//full by the lines
        for(int j = 0; j < columns; j++) 
        {
            array[i, j] = new Random().NextDouble() * ((max) - (min)) + (min); //randoming on crutches
            array[i, j] = Math.Round(array[i, j], 2);//rounding
        }
    return array;
}

void Print2DArray(double[,] array)// its fo check Creating2DRandomArray's working
{
    for(int i = 0; i < array.GetLength(0); i++)
    { 
        Console.WriteLine();
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " | ");
    }
    Console.WriteLine();
}

double[,] newone = Create2DRandomArray();
Print2DArray(newone);

// ex two

void FindElementOf2DArray(double[,] array)
{
    Console.WriteLine("Now, lets find your element");
    Console.WriteLine("Input the number of row:");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input the number of column:");
    int column = Convert.ToInt32(Console.ReadLine());

    if(row < array.GetLength(0) && column < array.GetLength(1))
        Console.WriteLine($"Element number {row} in {column} raw is {array[row - 1, column - 1]}");
        // added '-1' to find position, no index.
    else Console.WriteLine($"There is no such cell in the array");
}

FindElementOf2DArray(newone);

// ex three
//I know how to solveh the problem using one more array
//But it isn't too funny

void GenerateArrayWithAverage()
{
    Console.WriteLine("Input the number of row.");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input the number of column.");
    int column = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input the min possible value: ");
    double min = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Input the max possible value: ");
    double max = Convert.ToDouble(Console.ReadLine());
    
    double [,] array = new double[row + 1, column];// I use double because I dont want to make second array
    for(int i = 0; i < row; i++)                   // +1 row to take memory for averge numbers
        for(int j = 0; j < column; j++)
        {
            array[i, j] = new Random().NextDouble() * ((max) - (min)) + (min);
            array[i, j] = Math.Round(array[i, j], 0); // pseudo int number's crafting
            array[row, j] += array[i, j];// add to sum
        }
    for(int i = 0; i + 1 < array.GetLength(0); i++)// array's printing
    { 
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " | ");
        Console.WriteLine();
    }
    Console.WriteLine("Averge numbers:");
    for(int i = 0; i < array.GetLength(1); i++)// averge printing (last row)
    {
        double average = Math.Round(array[row, i] / row, 1);
        Console.Write(average + "|");
    }
}

GenerateArrayWithAverage();
*/