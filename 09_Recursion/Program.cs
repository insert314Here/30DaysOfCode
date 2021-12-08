Console.WriteLine("Enter a number to find its factorial value");
int n = Convert.ToInt32(Console.ReadLine());
int result = 0;
factorial(n);
Console.WriteLine($"{n} Factorial is equal to: {result}");
Console.ReadKey();


int factorial(int n)
{    

    if (n <= 1)
    {
        result = 1;
        return result;
    }
    else
    {
        result = n * factorial(n - 1);
        return result;
    }

    
}