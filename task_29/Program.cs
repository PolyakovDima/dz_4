ushort[] array = new ushort[8];
Random random = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = (ushort)random.Next(0, 1000);
}

Console.WriteLine($"[{string.Join(", ", array)}]");

