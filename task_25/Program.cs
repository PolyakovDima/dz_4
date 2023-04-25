int baseNumber, power;
bool baseNumberParsed, powerParsed;

do
{
    Console.Write("Enter the base number: ");
    baseNumberParsed = int.TryParse(Console.ReadLine(), out baseNumber);
    if (!baseNumberParsed)
    {
        Console.WriteLine("Error: Invalid base number");
    }
} while (!baseNumberParsed);

do
{
    Console.Write("Enter the power: ");
    powerParsed = int.TryParse(Console.ReadLine(), out power);
    if (!powerParsed)
    {
        Console.WriteLine("Error: Invalid power");
    }
} while (!powerParsed);

if (baseNumber == 0 && power == 0)
{
    Console.WriteLine("Error: 0^0 is undefined");
}
else if (baseNumber == 0 && power < 0)
{
    Console.WriteLine("Error: Cannot raise 0 to a negative power");
}
else
{
    int result = 1;
    bool error = false;

    for (int i = 1; i <= Math.Abs(power); i++)
    {
        if (baseNumber == 0)
        {
            result = 0;
            break;
        }
        else if (power == 0)
        {
            result = 1;
            break;
        }
        else if (power < 0)
        {
            if (i == 1)
            {
                result = baseNumber;
            }
            else
            {
                if (result == int.MinValue / baseNumber)
                {
                    error = true;
                    Console.WriteLine("Error: Integer underflow");
                    break;
                }
                else
                {
                    result *= baseNumber;
                }
            }
        }
        else
        {
            if (result == int.MaxValue / baseNumber)
            {
                error = true;
                Console.WriteLine("Error: Integer overflow");
                break;
            }
            else
            {
                result *= baseNumber;
            }
        }
    }

    if (!error)
    {
        if (power < 0)
        {
            Console.WriteLine($"Result: {1.0 / result}");
        }
        else
        {
            Console.WriteLine($"Result: {result}");
        }
    }
}
