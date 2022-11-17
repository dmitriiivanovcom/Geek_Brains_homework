/*
// ex one (64)
void FromNuberToOne(int number)
{
    if(number > 0){Console.Write(number + ", ");number--;FromNuberToOne(number);}
}

int num = 10;
FromNuberToOne(num);

// ex two (66)
int Dive(int n)
{if (n > 0) return Dive(n - 1) + n;else return 0;}

int FindSumOfNatural(int m, int n)
{
    int count = n - m;
    int result = m * (count + 1) + Dive(count);
    return result;
}

void InterfaceOfSumOfNatural()
{
    Console.WriteLine("Please, add first natural number.");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please, add second natural number.");
    int N = Convert.ToInt32(Console.ReadLine());
    if(M > N) Console.WriteLine($"N = {N}; M = {M} -> {FindSumOfNatural(N, M)}");
    if(M < N) Console.WriteLine($"N = {M}; N = {N} -> {FindSumOfNatural(M, N)}");
    else Console.WriteLine("Its equals");
}

InterfaceOfSumOfNatural();


// ex last one (68)

int Akkerman(int m, int n)
{
    if(m == 0) return n + 1;
    if(m != 0 && n == 0) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));
}

void AkkermanRun()
{
    Console.WriteLine("Please, add positive m.");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please, add positive n.");
    int n = Convert.ToInt32(Console.ReadLine());

    if(m < 0 || n < 0) Console.WriteLine("Its negative number!");
    if(m >= 4) Console.WriteLine("You want too much, guy!");
    if(m > 3 || n > 11) Console.WriteLine("Its too much for my processor!");
    else
    {
        int result = Akkerman(m, n);
        Console.WriteLine($"if m = {m}, n = {n} -> Akkerman(m, n) = {result}");
    }

}

AkkermanRun();
*/