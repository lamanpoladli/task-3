float customer = 1200;
if (customer < 100) 
{
    Console.WriteLine("5%endirim");
}
else if (customer >= 100 && customer <= 1000) 
{
    Console.WriteLine("8%endirim");
}
else
{
    Console.WriteLine("10%endirim");
}