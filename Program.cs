void cat()
{
    Console.WriteLine("/|---/|");
    Console.WriteLine("| o_o |");
    Console.WriteLine(" |_^_| ");
}
cat();

void userimput()
{
    while (true)
    {
        Console.WriteLine("choose a number");
        string userInput = Console.ReadLine();

        Console.WriteLine(userInput);
        break;
    }
}
userimput();
int add(int x, int y)
{
    int z = x + y;
    z = x + y;
    return z;

}
add(5, 6);

int subtract(int x, int y)
{
    int z = x - y;

    return z;
}
subtract(8, 9);

int multiply(int x, int y)
{
    int z = x * y;
    return z;
}

int divide(int x, int y)
{
    int z = x / y;
    return z;
}
Console.WriteLine("please decide if you would like to see addition, subtraction, multiplication, division");
Console.WriteLine("addition example type 1");
Console.WriteLine("subtraction example type 2");
Console.WriteLine("multiplication example type 3");
Console.WriteLine("division example type 4");
int userinput = int.Parse(Console.ReadLine());
int x = userinput;

while (true)
{
    if (x == 1)
    {

        Console.WriteLine("5+6 =");
        Console.WriteLine(add(5, 6));
    }
    else if (x == 2)
    {
        Console.WriteLine("8-9=");
        Console.WriteLine(subtract(8, 9));
    }
    else if (x == 3)
    {

        Console.WriteLine("10*9");
        Console.WriteLine(multiply(10, 9));
    }
    else if (x==4)
    {
        x = 4;
        Console.WriteLine("64/8");
        Console.WriteLine(divide(64, 8));}
else 
{
Console.WriteLine( "invalid input");
} break;
}
    
