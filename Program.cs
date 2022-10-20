// ex one
/*
int CurrentOfPositive(int num)
{
    int current = 0;
    int i = 0;
    do
    {
        Console.WriteLine("Add next one!");
        double a = Convert.ToDouble(Console.ReadLine());
        if(a > 0) 
        {
            current++;
            i++;
        }
        else i++;
    }
    while(i < num);
    return current;
}
Console.WriteLine("How many elements you want to check?");
int num = Convert.ToInt32(Console.ReadLine());
int nomOfPositive = CurrentOfPositive(num);
Console.WriteLine("Number of positive digits is " + nomOfPositive);
*/

// ex two
/*
void FindXAndY()
    {
        Console.WriteLine("add K1.");
        double k1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("add B1.");
        double b1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("add K2.");
        double k2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("add B2.");
        double b2 = Convert.ToDouble(Console.ReadLine());
        double x = (b1 - b1)/(k1 - k2);
        double y = x * k1 + b1;
        Console.WriteLine($"The point of cross is in x = {x}; y = {y}");
    }
FindXAndY();
*/