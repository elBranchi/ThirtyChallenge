var theWhat = new[] { 24605, 230729, 291466, 402475, 458220, 638439,
    667938, 695237, 702662, 731612, 855444, 899879, 929834 };

void DoTheThing()
{
    for (var i = 0; i < theWhat.Length; i++)
    {
        var r = new Random(theWhat[i]);
        var n = i;
        var c = char.MinValue;
        while (n >= 0)
        {
            var next = r.Next(char.MinValue, char.MaxValue);
            c = Convert.ToChar(next);
            n--;
        }
        Console.Write(c);
    }
}
DoTheThing();