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