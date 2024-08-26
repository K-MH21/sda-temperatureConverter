static string TempConvert(double temp, string tempType)
{
    if (tempType == "F")
    {
        return (5.0 * (temp - 32) / 9).ToString() + " C";
    }
    return (temp * 9 / 5 + 32).ToString() + " F";
}

Console.WriteLine("Enter a temperature and its unit (C or F):");
string oldTemp = Console.ReadLine();
string[] oldTempArr = oldTemp.Split(" ");

double oldTempAmount = Convert.ToDouble(oldTempArr[0]);
string oldTempType = oldTempArr[1];

string newTemp = TempConvert(oldTempAmount , oldTempType);
string[] newTempArr = newTemp.Split(" ");

double newTempAmount = Convert.ToDouble(newTempArr[0]);
string newTempType = newTempArr[1];

Console.WriteLine($"Converted: {oldTempAmount:F2} {oldTempType} = {newTempAmount:F2} {newTempType}");
