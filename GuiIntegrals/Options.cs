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
        private static Dictionary<string, object> context = new Dictionary<string, object>();
        private static NReco.Linq.LambdaParser parser = new NReco.Linq.LambdaParser();
        static Functions()
        {
            context["pi"] = Math.PI;
            context["e"] = Math.E;
        }

        public static double ComputedFunction(double x)
        {
            return Math.PI * Math.Pow(x, 1.5) / (x * x + 1);
        }

        public static double EvaluteFunction(string expression, double x)
        {
            context["x"] = x;
            var o = parser.Eval(expression, context);
            return double.Parse(string.Format("{0}", o));
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
