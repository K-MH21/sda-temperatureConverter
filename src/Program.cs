class Program
{
    static string TempConvert(double temp, TemperatureTypes tempType)
    {
        if (tempType == TemperatureTypes.F)
        {
            return (5.0 * (temp - 32) / 9).ToString() + " C";
        }
        return (temp * 9 / 5 + 32).ToString() + " F";
    }

    static void Main(String[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter a temperature and its unit (C or F):");
            string oldTemp = Console.ReadLine();

            if (oldTemp == "Quit")
                break;
            if (string.IsNullOrWhiteSpace(oldTemp))
            {
                Console.WriteLine("Enter an amount followed by either C or F");
                continue;
            }
            string[] oldTempArr = oldTemp.Split(" ");

            if (oldTempArr.Length != 2)
            {
                Console.WriteLine("Please Enter only the amount and the type (For example, \"30 C\")");
                continue;
            }
            double oldTempAmount;
            if (!double.TryParse(oldTempArr[0], out oldTempAmount))
            {
                System.Console.WriteLine("Please write the first value using digits");
                continue;
            }

            char oldTempType;
            if (!char.TryParse(oldTempArr[1].ToLower(), out oldTempType))
            {
                System.Console.WriteLine("Please write the second value using only 1 character (either C or F)");
                continue;
            }
            TemperatureTypes? oldTempTypeEnum = null;
            if (oldTempType.Equals('c'))
            {
                oldTempTypeEnum = TemperatureTypes.C;
            }
            if (oldTempType.Equals('f'))
            {
                oldTempTypeEnum = TemperatureTypes.F;
            }
            if (oldTempTypeEnum == null)
            {
                System.Console.WriteLine("You have to either write C or F");
                continue;
            }
            string newTemp = TempConvert(oldTempAmount, oldTempTypeEnum.Value);
            string[] newTempArr = newTemp.Split(" ");

            double newTempAmount = Convert.ToDouble(newTempArr[0]);
            string newTempType = newTempArr[1];

            Console.WriteLine($"Converted: {oldTempAmount:F2} {oldTempType} = {newTempAmount:F2} {newTempType}");
        }

        Console.WriteLine("Program terminated.");
    }


    enum TemperatureTypes { C, F }

}