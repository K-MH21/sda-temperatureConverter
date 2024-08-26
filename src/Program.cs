static string TempConvert(double temp, string tempType)
{
    if (tempType == "F")
    {
        return (5.0 * (temp - 32) / 9).ToString() + " C";
    }
    return (temp * 9 / 5 + 32).ToString() + " F";
}

Console.WriteLine(TempConvert(32, "F"));
Console.WriteLine(TempConvert(100, "C"));
