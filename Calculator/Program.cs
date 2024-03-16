using System.ComponentModel.Design;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic.CompilerServices;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine(Calculator.Calculate("((8*4)/2)+1"));
        }
    }


     class Calculator
    {
        public static float Calculate(string expression)
        {
            var tokens = Tokenize(expression).ToList();
            var result = evaluate(tokens);
            return result;
                
        }

        //recursive function to evaluate result 
        private static float evaluate(List<Tokens> tokens)
        {
            tokens = evalauteBrackets(tokens);
            tokens = evalauteOperation(tokens,"/");
            tokens = evalauteOperation(tokens,"*");
            tokens = evalauteOperation(tokens,"+");
            tokens = evalauteOperation(tokens, "-");
            return tokens[0].value;

        }

        private static List<Tokens> evalauteOperation(List<Tokens> tokens,string operation)
        {
            var operatorCount = tokens.Where(x => x.type == Type.Operator).Count();
            while (true)
            {
                switch (operation)
                {
                    case "+":
                        tokens = doAddition(tokens); break;
                    case "-":
                        tokens = doSubtraction(tokens); break;
                    case "*":
                        tokens = doMultiplication(tokens); break;
                    case "/":
                        tokens = doDivision(tokens); break;
                }
                var newCount = tokens.Where(x => x.type == Type.Operator).Count();
                if (newCount < operatorCount)
                    operatorCount = newCount;
                else
                    break;
            }
            return tokens;
        }

        private static List<Tokens> doSubtraction(List<Tokens> tokens)
        {
            var firstIndex = GetFistIndex("-", tokens);
            if (firstIndex == -1)
                return tokens;
            var bits = tokens.Skip(firstIndex - 1).Take(3).ToList();
            var result = bits[0].value - bits[2].value;
            var newTokens = tokens.Take(firstIndex - 1).ToList();
            if (result.ToString() != "")
                newTokens.Add(new Tokens(result.ToString(), true));
            newTokens.AddRange(tokens.Skip(firstIndex + 2));
            return newTokens;
        }


        private static List<Tokens> doMultiplication(List<Tokens> tokens)
        {
            var firstIndex = GetFistIndex("*", tokens);
            if (firstIndex == -1)
                return tokens;
            var bits = tokens.Skip(firstIndex - 1).Take(3).ToList();
            var result = bits[0].value * bits[2].value;
            var newTokens = tokens.Take(firstIndex - 1).ToList();
            if (result.ToString() != "")
                newTokens.Add(new Tokens(result.ToString(), true));
            newTokens.AddRange(tokens.Skip(firstIndex + 2));
            return newTokens;
        }


        private static List<Tokens> doDivision(List<Tokens> tokens)
        {
            var firstIndex = GetFistIndex("/", tokens);
            if (firstIndex == -1)
                return tokens;
            var bits = tokens.Skip(firstIndex - 1).Take(3).ToList();
            var result = bits[0].value / bits[2].value;
            var newTokens = tokens.Take(firstIndex - 1).ToList();
            if (result.ToString() != "")
                newTokens.Add(new Tokens(result.ToString(), true));
            newTokens.AddRange(tokens.Skip(firstIndex + 2));
            return newTokens;
        }



        private static List<Tokens> doAddition(List<Tokens> tokens)
        {
            var firstIndex= GetFistIndex("+",tokens);
            if (firstIndex == -1)
                return tokens;
            var bits = tokens.Skip(firstIndex - 1).Take(3).ToList();
            var result = bits[0].value + bits[2].value;
            var newTokens = tokens.Take(firstIndex-1).ToList();
            if (result.ToString() != "")
                newTokens.Add(new Tokens(result.ToString(),true));
            newTokens.AddRange(tokens.Skip(firstIndex+2));
            return newTokens;
        }

        private static int GetFistIndex(string Operator, List<Tokens> tokens)
        {
            for (int i = 0; i < tokens.Count; i++)
            {
                if (tokens[i].token == Operator)
                    return i;
                else
                    continue;
            
            }
            return -1;
        }

        private static List<Tokens> evalauteBrackets(List<Tokens> tokens)
        {
            var newTokens = new List<Tokens>();

            for (var index = 0; index < tokens.Count; index++)
            {
                var token = tokens[index];
                if (token.type == Type.OpenBracket)
                {
                    int end = FindMatchingEndBracket(tokens, index);
                    var inBrackets = tokens.Slice(index + 1, end - index - 1);
                    var value = evaluate(inBrackets);
                    newTokens.Add(new Tokens(value.ToString(), true));
                    index = end;
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
                switch (tokens[index].type)
                {
                    case Type.OpenBracket:
                        depth++; break;
                    case Type.ClosedBracket:
                        depth--; break;
                }

                if (depth == 0)
                    return index;
            }

            throw new NotImplementedException();
        }

        private static IEnumerable<Tokens> Tokenize(string expression)
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
                    yield return new Tokens(c.ToString(),false);
                    bit = "";
                }

            }
            if (!string.IsNullOrEmpty(bit))
                yield return new Tokens(bit,true);


        }
    }

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
    
    enum Type { Operator, Number , None, OpenBracket ,ClosedBracket}


}