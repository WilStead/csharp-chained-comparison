using System;

namespace Chain
{
  public static class Program
  {
    public static void Main()
    {
      ConditionalChaining(1, 2, 3);
      ConditionalChaining(1, 2, 0);
      ConditionalChaining(3, 2, 1);

      if ((ChainInt) 3 > 2 > 1)
        Console.WriteLine("if statement example");
    }

    private static void ConditionalChaining(ChainInt x, int y, int z)
    {
      bool result = x < y < z;
      Console.WriteLine(string.Format("{0} < {1} < {2}: {3}", x, y, z, result));
    }
  }

  public struct ChainInt
  {
    public int Value { get; private set; }

    public static implicit operator ChainInt(int value)
    {
      return new ChainInt { Value = value };
    }

    public static implicit operator int(ChainInt value)
    {
      return value.Value;
    }

    public static ChainBool operator <(ChainInt left, ChainInt right)
    {
      return new ChainBool(left.Value < right.Value, right.Value);
    }

    public static ChainBool operator >(ChainInt left, ChainInt right)
    {
      return new ChainBool(left.Value > right.Value, right.Value);
    }

    public override string ToString() { return ""+Value; }
  }

  public struct ChainBool
  {
    public ChainBool(bool boolValue, int left)
    {
      Value = boolValue;
      Left = left;
    }

    public bool Value { get; private set; }
    public int Left { get; private set; }

    public static implicit operator bool(ChainBool wrapper)
    {
      return wrapper.Value;
    }

    public static ChainBool operator <(ChainBool resultSoFar, ChainInt i)
    {
      return new ChainBool(resultSoFar.Value && resultSoFar.Left < i.Value, i.Value);
    }

    public static ChainBool operator >(ChainBool resultSoFar, ChainInt i)
    {
      return new ChainBool(resultSoFar.Value && resultSoFar.Left > i.Value, i.Value);
    }

    public override string ToString() { return ""+Value; }
  }
}
