using System.Text;

namespace Calculator;

public class Calculator
{
    public static float Calculate(string expression)
    {
        var tokens = Tokenizer.Tokenize(expression).ToList();
        var result = evaluate(tokens);
        return result;
                
    }

    private static float evaluate(List<Tokens> tokens)
    {
        //bidmas 
        tokens = evalauteBrackets(tokens);
        tokens = evalauteOperation(tokens, "^");
        tokens = evalauteOperation(tokens,"/");
        tokens = evalauteOperation(tokens,"*");
        tokens = evalauteOperation(tokens,"+");
        tokens = evalauteOperation(tokens, "-");
        return ((NumericToken) tokens[0]).value;

    }

    private static List<Tokens> evalauteOperation(List<Tokens> tokens,string operation)
    {
        var operatorCount = tokens.OfType<OperatorToken>().Count(x => x.type == Type.Operator);
        while (true)
        {
            tokens.DumpTokens(operation);
            tokens = DoOperation(tokens, operation);
            var newCount = tokens.OfType<OperatorToken>().Count(x => x.type == Type.Operator);
            if (newCount < operatorCount)
                operatorCount = newCount;
            else
                break;
        }
        return tokens;
    }


    private static List<Tokens> DoOperation(List<Tokens> tokens,string operation)
    {
        var firstIndex = GetFistIndex(operation, tokens);
        if (firstIndex == -1)
            return tokens;
        var bits = tokens.Skip(firstIndex - 1).Take(3).ToList();
        var result = 0f;
        var left = (NumericToken) bits[0];
        var right = (NumericToken)bits[2];
        switch (operation)
        {
            case "/":
                result = left.value / right.value; break;               
            case "*":
                result = left.value * right.value; break;
            case "+":
                result = left.value + right.value; break;
            case "-":
                result = left.value - right.value; break;
            case "^":
                result = (float) (Math.Pow(left.value, right.value)); break;
        }
        var newTokens = tokens.Take(firstIndex - 1).ToList();
        newTokens.Add(new NumericToken(result));
        newTokens.AddRange(tokens.Skip(firstIndex + 2));
        return newTokens;
    }

    private static int GetFistIndex(string op, List<Tokens> tokens)
    {
        for (int i = 0; i < tokens.Count; i++)
        {
            if (tokens[i] is OperatorToken ot)
            {
                if (ot.Operator == op)
                    return i;
            }
        }
        return -1;
    }

    private static List<Tokens> evalauteBrackets(List<Tokens> tokens)
    {
        var newTokens = new List<Tokens>();

        for (var index = 0; index < tokens.Count; index++)
        {
            if (tokens[index] is OperatorToken ot)
            {
                if (ot.type == Type.OpenBracket)
                {
                    int end = FindMatchingEndBracket(tokens, index);
                    var inBrackets = tokens.Slice(index + 1, end - index - 1);
                    var value = evaluate(inBrackets);
                    newTokens.Add(new NumericToken(value));
                    index = end;
                }
                else
                {
                    newTokens.Add(tokens[index]);
                }
            }
            else
            {
                newTokens.Add(tokens[index]);
            }
        }
            
            
        return newTokens;
    }

    private static int FindMatchingEndBracket(List<Tokens> tokens, int Startindex)
    {
        var depth = 0; 
        for (var index = Startindex; index < tokens.Count; index++)
        { 
            switch (tokens[index])
            {
                case OperatorToken operatorToken:
                    if (operatorToken.type == Type.OpenBracket)
                        depth++;
                    else if (operatorToken.type == Type.ClosedBracket)
                        depth--;
                    break;
            }

            if (depth == 0)
                return index;
        }

        throw new Exception("Brackets do not Match");
    }



}