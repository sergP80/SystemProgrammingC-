using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NumericIntegral;

namespace GuiIntegrals
{
    internal static class Functions
    {
        public static double ComputedFunction(double x)
        {
            return Math.PI * Math.Pow(x, 1.5) / (x * x + 1);
        }
    }

    internal static class Methods
    {
        static IntegralMethod[] integralMethods = {
            Integrals.LeftRect,
            Integrals.RightRect,
            Integrals.MidRect
        };

        public static IntegralMethod GetIntegralMethod(this Control control, int index)
        {
            return integralMethods[index];
        }
    }
}
