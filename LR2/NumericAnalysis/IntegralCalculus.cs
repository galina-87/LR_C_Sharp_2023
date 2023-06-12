using System;

namespace NumericAnalysis;

public class IntegralCalculus
{
    public static double Calculate(Func<double, double> func, double x1, double x2, double precision)
    {
        double y1 = func(x1), x1tek;
        double y2 = func(x2), x2tek;
        double res1, res2;
        int col = 2;
        //throw new NotImplementedException();

        res2 = ((y1 + y2) * Math.Abs(x2 - x1)) / 2;
        double step = Math.Abs(x2 - x1)/col;
        do
        {
            res1 = res2;
            res2 = 0;
            for (int i = 0; i < col; i++)
            {
                x1tek = x1 + step * i;
                x2tek = x1 + step * (i + 1);
                
                y1 = func(x1tek);
                y2 = func(x2tek);
                
                res2 += ((y1 + y2) * step) / 2;
            }
            
            col *= 2;
            step = Math.Abs(x2 - x1) / col;
        } while (Math.Abs(res1 - res2) > precision);
        
        return res2;
    }
}
