int number = ReadInt("number");

int ReadInt(string argument)
{
    int n;
    bool checkingNumber;

    do
    {
        Console.Write($"Input a {argument}: ");
        
        checkingNumber = int.TryParse(Console.ReadLine(), out n);
    }
    while (!checkingNumber);
    return n;
}

int sum = 0;
int temp = number;
while (temp > 0)
{
    int digit = temp % 10;
    sum += digit;
    temp /= 10;
}

Console.WriteLine($"The sum of digits in {number} is {sum}.");