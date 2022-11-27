Console.Clear();
Console.WriteLine("Enter three-digit number: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 1000 && n > 100)
{
    Console.Write("The second digit of this number: ");
    Console.Write(n / 10 % 10);
}
else 
{
    Console.WriteLine("Three-digit number!");
}