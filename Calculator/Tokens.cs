namespace Calculator;

public class Tokens
{

}

class NumericToken : Tokens
{
    public Decimal value = 0;
    public NumericToken(string newbit)
    {
        value = Decimal.Parse(newbit);
    }


    public NumericToken(Decimal value)
    {
        this.value = value;
    }

    public override string ToString()
    {
        return $"{value}";
    }
}

class OperatorToken : Tokens
{
    public string Operator;
    public Type type;

    public OperatorToken(string newBit)
    {
        switch (newBit)
        {
            case "(":
                type = Type.OpenBracket; break;
            case ")":
                type = Type.ClosedBracket; break;
            default:
                type = Type.Operator; break;
        }
        Operator = newBit;
    }

    public override string ToString()
    {
        return $"{Operator}";
    }
}




static class Tokenizer
{
    public static IEnumerable<Tokens> Tokenize(string expression)
    {
        var bit = "";
        foreach (var c in expression)
        {
            if (char.IsDigit(c) || c == '.')
                bit += c;
            else
            {
                if (bit.Length > 0)
                    yield return new NumericToken(bit);
                yield return new OperatorToken(c.ToString());
                bit = "";
            }

        }
        if (!string.IsNullOrEmpty(bit))
            yield return new NumericToken(bit);


    }

}

