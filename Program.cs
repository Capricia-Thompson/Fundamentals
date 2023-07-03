Console.WriteLine("Loop for 1-255");
for (int i = 1; i <= 255; i++)
{
    Console.WriteLine(i);
};

Random rand = new Random();

Console.WriteLine("Loop for 5 random numbers between 10 and 20");
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(rand.Next(10, 21));
};

Console.WriteLine("Modified previous loop with sum");

int sum = 0;
for (int i = 1; i <= 5; i++)
{
    sum += rand.Next(10, 21);
    if (i == 5) { Console.WriteLine(sum); };
};

Console.WriteLine("Loop for multiples of 3 or 5");

for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        continue;
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine(i);
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine(i);
    }
}

Console.WriteLine("Fizz or Buzz");

for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        continue;
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
}

Console.WriteLine("FizzBuzz Loop");

for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
}
