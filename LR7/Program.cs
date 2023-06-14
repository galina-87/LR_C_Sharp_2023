
using LR7;

double[] doubles = new double[10];
for (int i = 0; i < doubles.Length; i++)
{
    doubles[i] = (double)i*i-5;
}

Console.WriteLine("Начальный массив double:");
doubles.PrintEnum();

double[] d0 = doubles.TakeOdd().ToArray();
Console.WriteLine("Массив TakeOdd():");
d0.PrintEnum();

double[] d1 = doubles.TakeEven().ToArray();
Console.WriteLine("Массив TakeEven():");
d1.PrintEnum();

double[] d2 = doubles.TakeNegative().ToArray();
Console.WriteLine("Массив TakeNegative():");
d2.PrintEnum();

double[] d3 = doubles.TakePositive().ToArray();
Console.WriteLine("Массив TakePositive():");
d3.PrintEnum();

double[] d4 = doubles.SmoothByMovingAverage(4).ToArray();
Console.WriteLine("Массив SmoothByMovingAverage(4):");
d4.PrintEnum();


decimal[] decimales = new decimal[10];
for (int i = 0; i < decimales.Length; i++)
{
    decimales[i] = (decimal)i * i / 5;
}

Console.WriteLine("Начальный массив decimal:");
decimales.PrintEnum();

decimal[] dec0 = decimales.TakeOdd().ToArray();
Console.WriteLine("Массив TakeOdd():");
dec0.PrintEnum();

decimal[] dec1 = decimales.TakeEven().ToArray();
Console.WriteLine("Массив TakeEven():");
dec1.PrintEnum();

decimal[] dec2 = decimales.TakeNegative().ToArray();
Console.WriteLine("Массив TakeNegative():");
dec2.PrintEnum();

decimal[] dec3 = decimales.TakePositive().ToArray();
Console.WriteLine("Массив TakePositive():");
dec3.PrintEnum();

decimal[] dec4 = decimales.SmoothByMovingAverage(4).ToArray();
Console.WriteLine("Массив SmoothByMovingAverage(4):");
dec4.PrintEnum();


int[] ints = new int[10];
for (int i = 0; i < ints.Length; i++)
{
    ints[i] = i * i - 7;
}

Console.WriteLine("Начальный массив int:");
ints.PrintEnum();

int[] i0 = ints.TakeOdd().ToArray();
Console.WriteLine("Массив TakeOdd():");
i0.PrintEnum();

int[] i1 = ints.TakeEven().ToArray();
Console.WriteLine("Массив TakeEven():");
i1.PrintEnum();

int[] i2 = ints.TakeNegative().ToArray();
Console.WriteLine("Массив TakeNegative():");
i2.PrintEnum();

int[] i3 = ints.TakePositive().ToArray();
Console.WriteLine("Массив TakePositive():");
i3.PrintEnum();

int[] i4 = ints.SmoothByMovingAverage(4).ToArray();
Console.WriteLine("Массив SmoothByMovingAverage(4):");
i4.PrintEnum();