using System;

class Program
{
    public static void Main(string[] args)
    {
    Random random = new Random();
        string[] names = { "Alice", "Bob", "Charlie", "David", "Eve" };
        string[] birthdates = { "01/01/2000", "02/02/2001", "03/03/2002", "04/09/2003", "05/05/2004" };
            int nameIndex = random.Next(names.Length);
        int birthdateIndex = random.Next(birthdates.Length);
        string workPhone = $"({random.Next(100, 999)}) {random.Next(100, 999)}-{random.Next(1000, 9999)}";
        string homePhone = $"({random.Next(100, 999)}) {random.Next(100, 999)}";
            Console.WriteLine(names[nameIndex]);
            Console.WriteLine(birthdates[birthdateIndex]);
Console.WriteLine($"work: {workPhone}");
Console.WriteLine($"home: {homePhone}");
    }
}