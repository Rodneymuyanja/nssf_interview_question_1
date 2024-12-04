

using System.Text;

var str = ValidString("a)b(c)d");
Console.WriteLine(str);

string ValidString(string str)
{
    StringBuilder sb = new ();

    Stack<char> s = new ();
    foreach (var c in str)
    {
        s.Push (c);
    }

    while(s.Peek() != ')')
    {
        if(s.Peek() == '(' && s.Peek() == '(')
        {
            continue;
        }

        sb.Append (s.Pop());    
    }

    sb.Append(s.Pop());
    if(s.Peek() != ')')
    {
        while(s.Peek () != ')')
        {
            sb.Append (s.Pop());
        }
    }

    return sb.ToString ();
}