double[] rain = { };
while (true)
{
    Console.Clear();
    switch (WriteInt("Menu\n1 Inset data:\n2 Average:\n3 Max Value:\n4 Min value:\n5 show all values: "))
    {
        case 1:
            rain = InsetData(WriteInt("How many Days: "));
            break;
        case 2:
            Console.WriteLine(Sum(rain));
            Console.ReadKey();
            break;
        case 3:
            Console.WriteLine(MaxValue(rain));
            Console.ReadKey();
            break;
        case 4:
            Console.WriteLine(MinValue(rain));
            Console.ReadKey();
            break;
        case 5:
            PrintArray(rain);
            Console.ReadKey();
            break;
        default:
            break;
    }
}
static double WriteDouble(string text)
{
    double value;
    while (true)
    {
        Console.Clear();
        Console.Write(text);
        try
        {
            return value = Convert.ToDouble(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
static int WriteInt(string text)
{
    int value;
    while (true)
    {
        Console.Clear();
        Console.Write(text);
        try
        {
            return value = Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
static double[] InsetData(int number)
{
    string[] weeks = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
    double[] countsInput = new double[number];
    int weekCount = 0;
    Console.Clear();
    for (int i = 0; i < number; i++)
    {
        countsInput[i] = WriteDouble($"skriv tal for {weeks[weekCount]}: ");
        weekCount++;
        if (weekCount == 7)
            weekCount = 0;
    }
    return countsInput;
}
static string MinValue(double[] array)
{
    Console.Clear();
    if (array.Length > 0)
        return String.Format("Minimum value: {0:F2}", array.Min());
    else
        return "Need some input, try 1 in menu";
}
static string MaxValue(double[] array)
{
    Console.Clear();
    if (array.Length > 0)
        return String.Format("Max value: {0:F2}", array.Max());
    else
        return "Need some input, try 1 in menu";
}
static string Sum(double[] array)
{
    Console.Clear();
    if (array.Length > 0)
        return String.Format("Average value: {0:F2}", Queryable.Average(array.AsQueryable()));
    else
        return "Need some input, try 1 in menu";
}
static void PrintArray(double[] array)
{
    Console.Clear();
    if (array.Length > 0)
        for (int i = 0; i < array.Length; i++)
            Console.WriteLine($"Måleværdi {i + 1} = " + "{0:F1}", array[i]);
    else
        Console.WriteLine("Need some input, try 1 in menu");
}