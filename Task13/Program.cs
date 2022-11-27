Console.Clear();
Console.WriteLine("Enter any number: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 10000;
int a = 10;
if (n < 100)
{
    Console.WriteLine("No third digit");
}
else
{
    if (n < 1000)
    {
        Console.Write("Third digit is: ");
        Console.Write(n % 10);
    }
    else 
    {
        while (n > i)
        {
            a = a * 10;
            i = i * 10;
            
        }
        Console.Write("Third digit is: ");
        Console.Write(n / a % 10);
        
    }
}