namespace Calc;
public class Calculator
{
    public int Add(int firstNum, int secondNum)
    {
        return (firstNum, secondNum) switch
        {
            ( > 0, > 0) => firstNum + secondNum,
            ( > 0, <= 0) => -1,
            ( <= 1, > 0) => -2,
            (_) => 0
        };
    }
}
