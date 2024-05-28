namespace LeedCode.Test.LinkedList;

public class Result
{
    public int Sum { get; set; }
    public int Position { get; set; }
}
public class ConvertBinaryNumberToInteger
{
    public int GetDecimalValue(Node head)
    {
        return Recurse(head).Sum;
    }

    private Result Recurse(Node head)
    {
        if (head.Next is null)
        {
            return new Result() { Position = 1, Sum = Power(0) * head.Data };
        }
        else
        {
            var nextResult = Recurse(head.Next);
            return new Result()
            {
                Position = nextResult.Position + 1,
                Sum = nextResult.Sum + (Power(nextResult.Position) * head.Data)
            };
        }
    }

    private int Power(int factor)
    {
        
        return (int)Math.Pow(2, factor);
    }
}
