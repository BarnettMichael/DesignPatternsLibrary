using System;
using static System.Console;

namespace ChainOfResponsibility.Utility
{
    public static class ConsoleInput
    {
        public static bool TryReadDecimal(string prompt, out Decimal value)
        {
            value = default(Decimal);

            while (true)
            {
                WriteLine(prompt);
                string input = ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    return false;
                }

                try
                {
                    value = Convert.ToDecimal(input);
                    return true;
                }
                catch (FormatException)
                {
                    WriteLine("The input is not a valid decimal");
                }
                catch (OverflowException)
                {
                    WriteLine("The input is not a valid decimal");
                }
            }
        }
    }

    
}
