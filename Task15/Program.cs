Console.Clear();
Console.Write("Enter day of the week: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 7)
{
    Console.Write("Wrong!\nEnter day of the week: ");
    n = Convert.ToInt32(Console.ReadLine());    
}
if (n <= 5)
{
    Console.WriteLine("No Holiday. I need go to work.");
}
else 
{
    Console.WriteLine("Holiday!!!!");
}