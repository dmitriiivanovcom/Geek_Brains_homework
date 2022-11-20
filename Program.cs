// ex one (54)
//Im using printing void in first and second ex
void Print2DArray(int[,] array)// Printing... () 
{
    Console.WriteLine("Array:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]);
            if(j < array.GetLength(1) - 1)
                Console.Write("| ");// its for buty
        }
        if(i < array.GetLength(0) - 1)
            Console.WriteLine("|");
        else Console.WriteLine("|");
    }
    Console.WriteLine();
}

int[,] Create2DRandomArray(int rows, int columns)//Creating 2d array
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(1, 10);
    return array;    
}

void SortByRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = j + 1; k < array.GetLength(1); k++)
                if (array[i,j] < array[i,k])
                {
                    int temp = array[i,k];
                    array[i,k] = array[i,j];
                    array[i,j] = temp;
                }
}
/*
Console.WriteLine("Input the Rows number");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the Columns number");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] newarray = Create2DRandomArray(rows, columns);
Print2DArray(newarray); //test
SortByRows(newarray);
Print2DArray(newarray); //test
*/
// ex two (55)
int[,] CreateSquareRandomArray(int side)//Creating square array, its to start by one number
{
    int[,] array = new int[side, side];
    for (int i = 0; i < side; i++)
        for (int j = 0; j < side; j++)
            array[i,j] = new Random().Next(1, 10);
    return array;    
}
void FindingMinRowAndPrintResult(int[,] array)
{
    int[] tempArray = new int [array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            tempArray[i] += array[i,j];
    int result = 1;
    int minValue = tempArray[0];
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        if(tempArray[i] < minValue)
        {
            minValue = tempArray[i];
            result = i + 1;
        }
    }
    Console.WriteLine("The row whose sum of elements is minimal");
    Console.WriteLine("          has the number " + result);

}

/*
Console.WriteLine("Input the size of side");
int side = Convert.ToInt32(Console.ReadLine());
int[,] squareArray = CreateSquareRandomArray(side);
Print2DArray(squareArray);
FindingMinRowAndPrintResult(squareArray);
*/

// ex three (58)

void DerivativeMatrix (int [,] arrayone, int[,] arraytwo)
{
    if(arrayone.GetLength(0) != arraytwo.GetLength(1))
        Console.WriteLine("I cant do it, these matrices are incompatible!");
    else
    {
        int[,] resultarray = new int[arrayone.GetLength(1), arraytwo.GetLength(0)];
        for (int i = 0; i < resultarray.GetLength(0); i++)
            for (int j = 0; j < resultarray.GetLength(1); j++)
                for (int n = 0; n < arrayone.GetLength(0); n++)
                    resultarray[i,j] += arrayone[n,j] * arraytwo[i,n];
        Print2DArray(resultarray);        
    }
}
/*
Console.WriteLine("Please, add the number of rows for first matrix.");
int rowsone = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please, add the number of columns for first matrix.");
int columnsone = Convert.ToInt32(Console.ReadLine());
int[,] matrixOne = Create2DRandomArray(rowsone, columnsone);
Console.WriteLine("Please, add the number of rows for second matrix.");
int rowstwo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please, add the number of columns for second matrix.");
int columnstwo = Convert.ToInt32(Console.ReadLine());
int[,] matrixTwo = Create2DRandomArray(rowstwo, columnstwo);
Print2DArray(matrixOne);
Print2DArray(matrixTwo);
DerivativeMatrix(matrixOne, matrixTwo);
*/

// ex four (60)

void Print3DArray (int[,,] array)
{
    Console.WriteLine("Array elements with coordinates.");
    for (int i = 0; i < array.GetLength(0); i++)
    { 
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int m = 0; m < array.GetLength(2); m++)
            {
                Console.Write(array[i,j,m] + "(" + i + "," + j + "," + m + ")");
                if(m < array.GetLength(2) - 1)
                Console.Write("   ");
            }
            if(j < array.GetLength(1) - 1)
                Console.WriteLine("  ");
            else Console.WriteLine("  ");
        }
        if(i < array.GetLength(0) - 1)
                Console.WriteLine("  ");
            else Console.WriteLine("  ");
    }
}


bool TrueRandom(int[] array, int number, int index)
{
    int current = 0;
    for (int i = 0; i < index; i ++)
        if(array[i] == number) current++;
    if(current == 0)
    return true;
    else return false;
}

int[] AlphaRandom(int size, int minimum, int maximum) 
{
    int[] resultArray = new int[size];
    resultArray[0] = new Random().Next(minimum, maximum + 1);
    for (int i = 1; i < resultArray.GetLength(0); i++)
    {
        int temp = new Random().Next(minimum, maximum +1);
        if(TrueRandom(resultArray, temp, i)) resultArray[i] = temp;
        else i -- ;
    }
    return resultArray;
}

int[,,] Create3DRandom(int x, int y, int z)
{
    int size = x * y * z;
    int[] tempArray = AlphaRandom(size, 1, size);
    int[,,] result = new int[x,y,z];
    int n = 0;
    for (int i = 0; i < x; i++)
        for (int j = 0; j < y; j++)
            for (int m = 0; m < z; m++) 
            {
                result[i,j,m] = tempArray[n];
                n++;
            }
    return result;
}


/*
Console.WriteLine("Arrd size.");
int size = Convert.ToInt32(Console.ReadLine());
Print3DArray(Create3DRandom(size,size,size));
*/

//ex five (62)

void MakeHelix(int[,] array)
{
    int x = array.GetLength(1);
    int y = array.GetLength(0);
    int size = x*y; x--; y = y - 2;
    int i = 0;
    int j = 0;
    int way = 0;     
    int number = 1;
    int count = 0;
    if(x % 2 == 0){int central = x / 2;array[central,central] = size;}// central crutch
    while (number < size)
    {
        if(way == 0)//go right
        {
            count = x;
            while (count > 0){array[i,j] = number; number++;j++;count--;}
            if(array[i,j] == 0) array[i,j] = number; number++;i++;x--;way = 1;
        }
        if (way == 1)// go down
        {
            count = y;
            while (count > 0){array[i,j] = number; number++;i++;count--;}
            if(array[i,j] == 0) array[i,j] = number; number++;j--;y--;way = 2;
        }
        if (way == 2)// go left
        {
            count = x;
            while (count > 0){array[i,j] = number; number++;j--;count--;}
            if(array[i,j] == 0) array[i,j] = number; number++;i--;x--;way = 3;    
        }
        if (way == 3)// go 
        {
            count = y;
            while (count > 0){array[i,j] = number; number++;i--;count--;}
            if(array[i,j] == 0) array[i,j] = number; number++;j++;y--;way = 0;
        }
    }
}
/*
Console.WriteLine("Please, specify the size of row.");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please, specify the size of column.");
int column = Convert.ToInt32(Console.ReadLine());
int[,] test = new int[column, row];
Print2DArray(test);
MakeHelix(test);
Print2DArray(test);
*/

baltaburger72