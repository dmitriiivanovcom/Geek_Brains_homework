// ex one
/*
int[] RandomThreeDigitArray(int size)
{
        int[] array = new int[size];
        for(int i = 0; i < size; i++)
            array[i] = new Random().Next(100, 1000);
        return array;
}
int CurrentOfEven(int[] array)
{
    int current = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0) current++;
    return current;
}
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
Console.WriteLine("Please, add arrays size.");
int newsize  = Convert.ToInt32(Console.ReadLine());
int [] newone = RandomThreeDigitArray(newsize);
PrintArray(newone);
int result = CurrentOfEven(newone);
Console.WriteLine($"There {result} even dogits in your array.");
*/

// ex two
/*
int[] RandomTwoDigitArray(int size) //здесь рандомный массив из двузначных поскольку:
{                                                           //во первых так в задании
        int[] array = new int[size];                        //во вторых какая разница?
        for(int i = 0; i < size; i++)
            array[i] = new Random().Next(10, 100);
        return array;
}
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int SumOfodd(int[] array)
{
int sum = 0;
for(int i = 0; i < array.Length; i++)
    if(i % 2 == 0) sum += array[i]; // с точки зрения пользователя это нечетные места
    return sum;                     // но компьютер считает с нуля, так что я искал четные
}

Console.WriteLine("Please add array's size.");
int size = Convert.ToInt32(Console.ReadLine());
int[] newone = RandomTwoDigitArray(size);
PrintArray(newone);
int result = SumOfodd(newone);
Console.WriteLine("Sum of odd-places digits is " + result);
*/

//ex three
/*
double[] RandomArray(int size)// не прошу интервал у пользователя(в основном это ленивый я) чтобы меньше кнопками тыкать
{
        double[] array = new double[size];
        for(int i = 0; i < size; i++)
           {
             array[i] = new Random().NextDouble() * (1000 + 1) - 1;// числа в массиве произвольные.
            array[i] = Math.Round(array[i], 3);
           }
        return array;   
}
void PrintArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
double difference(double[] array)
{
    double max = array[0];
    double min = array[0];
    for(int i = 0; i < array.Length; i++) if(array[i] > max) max = array[i];
    for(int i = 0; i < array.Length; i++) if(array[i] < min) min = array[i];
    double diff = max - min;
    return diff;
}

Console.WriteLine("Add array's size.");
int size = Convert.ToInt32(Console.ReadLine());
double[] newone = RandomArray(size);
PrintArray(newone);
double result = difference(newone);
Console.WriteLine("Its done, difference min/max is " + result);
*/
