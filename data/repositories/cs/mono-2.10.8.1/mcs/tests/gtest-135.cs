using System;

class X
{
    static void Main ()
    {
        int? a = null;
        int b = 3;
        long? c = a;
        Console.WriteLine (c);
        long? d = b;
        byte? f = (byte?) d;
    }
}
