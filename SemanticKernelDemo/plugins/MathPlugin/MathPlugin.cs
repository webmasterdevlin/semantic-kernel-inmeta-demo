using System.ComponentModel;
using System.Globalization;
using Microsoft.SemanticKernel;

namespace SemanticKernelDemo.plugins.MathPlugin;

public class Math
{
    [SKFunction, Description("Add two numbers")]
    public string Add([SKName("input"), Description("The first number to add")] string input,
                      [SKName("number2"), Description("The first number to add")] string number2)
    {
        return (
            Convert.ToDouble(input, CultureInfo.InvariantCulture) +
            Convert.ToDouble(number2, CultureInfo.InvariantCulture)
        ).ToString(CultureInfo.InvariantCulture);
    }

    [SKFunction, Description("Subtract two numbers")]
    public string Subtract([SKName("input"), Description("The first number to add")] string input, 
                           [SKName("number2"), Description("The first number to add")] string number2)
    {
        return (
            Convert.ToDouble(input, CultureInfo.InvariantCulture) -
            Convert.ToDouble(number2, CultureInfo.InvariantCulture)
        ).ToString(CultureInfo.InvariantCulture);
    }

    [SKFunction, Description("Multiply two numbers. When increasing by a percentage, don't forget to add 1 to the percentage.")]
    public string Multiply([SKName("input"), Description("The first number to add")] string input, 
                           [SKName("number2"), Description("The first number to add")] string number2)
    {
        return (
            Convert.ToDouble(input, CultureInfo.InvariantCulture) *
            Convert.ToDouble(number2, CultureInfo.InvariantCulture)
        ).ToString(CultureInfo.InvariantCulture);
    }

    [SKFunction, Description("Divide two numbers")]
    public string Divide([SKName("input"), Description("The first number to add")] string input, 
                         [SKName("number2"), Description("The first number to add")] string number2)
    {
        return (
            Convert.ToDouble(input, CultureInfo.InvariantCulture) /
            Convert.ToDouble(number2, CultureInfo.InvariantCulture)
        ).ToString(CultureInfo.InvariantCulture);
    }
}
