namespace Calculator;

class Tokens
{
    public string token;
    public Type type = Type.None;
    public float value;
    public Tokens(string newBit , bool isNum)
    {
        token = newBit;
        if (isNum)
        {
            type = Type.Number;
            value = float.Parse(newBit);
        }
        else
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
        }
    }

    public override string ToString()
    {
        return $"{type}, {token}";
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
                    yield return new Tokens(bit, true);
                yield return new Tokens(c.ToString(), false);
                bit = "";
            }

        }
        if (!string.IsNullOrEmpty(bit))
            yield return new Tokens(bit, true);


    }
}