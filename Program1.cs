// See https://aka.ms/new-console-template for more information


using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 18;
        int b = 6;
        int c = 2;
        int d = 3;
        double x = 5;
        double y = 4;
        double z = 2;

        Prog1.add(a, b);
        Prog1.sub(a, b);
        Prog1.mul(a, b);
        Prog1.div(a, b);
        Prog1.complex(a, b, c);
        Prog1.complex2(a, b, c, d);
        Prog1.findMinMax();
        Prog1.doubleArithametics(x, y, z);
        Prog1.roundingError();
        Prog1.decimalMinMax();
        Prog1.decimalVsDouble();
        Prog1.areaOfCircle();
    }
}
